using System;

namespace ConsoleApp1
{
    public class Pentagon : Shape
    {
        public Pentagon()
        {
            NumOfSides = 5;
        }

        public new void Draw()
        {
            Console.WriteLine($"Draw a pentagon with {NumOfSides}");
        }
    }
}
