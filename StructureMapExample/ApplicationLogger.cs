using System;

namespace StructureMapExample
{
    public class ApplicationLogger : ILogger
    {
        public void WriteInfo(string message)
        {
            var tempColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = tempColour;
        }
    }
}
