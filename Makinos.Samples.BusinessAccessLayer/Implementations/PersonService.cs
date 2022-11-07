using Makinos.Samples.BusinessAccessLayer.Interfaces;
using Makinos.Samples.DataAccessRepository.Interfaces;
using Makinos.Samples.Models;

namespace Makinos.Samples.BusinessAccessLayer.Implementations
{
    public class PersonService : IPersonService
    {
        IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void Save(Person person)
        {
            _personRepository.Save(person);
        }
    }
}
