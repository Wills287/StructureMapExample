using WebStructureMapExample.Models;

namespace WebStructureMapExample.Data
{
    public class PersonRepository : IPersonRepository
    {
        public Person GetPerson()
        {
            return new Person
            {
                FirstName = "M",
                LastName = "W"
            };
        }
    }
}
