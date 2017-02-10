using System;

namespace CoreStructureMapExample.Data
{
    public class StuffRepository : IMisnamedRepository
    {
        public string DoStuff()
        {
            return "Did stuff!";
        }
    }
}
