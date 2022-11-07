using Makinos.Samples.DataAccessRepository.Interfaces;
using Makinos.Samples.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Makinos.Samples.DataAccessRepository.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        IConfiguration _configuration;
        static readonly object obj = new object();
        public PersonRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Save(Person person)
        {
            string filepath = _configuration.GetValue<string>("FileSettings:FilePath");
            lock(obj)
            {
                List<Person> source = new List<Person>();

                using (StreamReader r = new StreamReader(filepath))
                {
                    string json = r.ReadToEnd();
                    if (!string.IsNullOrEmpty(json))
                    {
                        source = JsonSerializer.Deserialize<List<Person>>(json);
                    }
                }

                source.Add(person);

                string jsonString = JsonSerializer.Serialize(source, new JsonSerializerOptions() { WriteIndented = true });
                using (StreamWriter outputFile = new StreamWriter(filepath))
                {
                    outputFile.WriteLine(jsonString);
                }
            }
        }
    }
}
