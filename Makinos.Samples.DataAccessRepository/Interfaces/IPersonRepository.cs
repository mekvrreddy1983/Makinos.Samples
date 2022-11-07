using Makinos.Samples.Models;

namespace Makinos.Samples.DataAccessRepository.Interfaces
{
    public interface IPersonRepository
    {
        void Save(Person person);
    }
}
