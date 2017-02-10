using System;

namespace StructureMapExample
{
    public class Calculator : ICalculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Adding {x} and {y} - Result: {(x + y)}");
        }
    }
}
