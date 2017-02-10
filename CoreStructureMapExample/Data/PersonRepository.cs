using System;
using CoreStructureMapExample.Models;

namespace CoreStructureMapExample.Data
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
