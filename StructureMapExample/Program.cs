using StructureMap;
using System;

namespace StructureMapExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = Container.For<ApplicationRegistry>();

            var app = container.GetInstance<Application>();
            app.Run();
            Console.ReadLine();
        }
    }
}
