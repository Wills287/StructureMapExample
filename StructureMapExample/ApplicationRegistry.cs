using StructureMap;

namespace StructureMapExample
{
    public class ApplicationRegistry : Registry
    {
        public ApplicationRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            For<ILogger>().Use<ApplicationLogger>();
        }
    }
}
