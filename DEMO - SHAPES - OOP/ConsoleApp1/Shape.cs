using System;

namespace ConsoleApp1
{
    // This is a base class
    // Any of the shapes can iherit from it
    // They get the methods already inserted in there and they do not have to write there own methods

    public class Shape
    {
        protected int NumOfSides;
        protected string Colour;

        public void ChangeNumberOfSides(int sides)
        {
            if (sides < 1)
            {
                throw new ArgumentException("Sides can't be less than 1");
            }
            NumOfSides = sides;
        }

        public void Draw()
        {
            Console.WriteLine($"Draw a shape with {NumOfSides}");
        }
    }
}
