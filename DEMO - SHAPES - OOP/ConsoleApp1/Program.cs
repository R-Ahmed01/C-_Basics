using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 

            var circle = new Circle();
            circle.Draw();

            var square = new Square();
            square.Draw();

            var shape = new Shape();
            shape.Draw();

            var hexagon = new Hexagon();
            hexagon.Draw();

            var pentagon = new Pentagon();
            pentagon.Draw();

            IShape shapeInterface = new Hexagon();
            shapeInterface.Draw();
            shapeInterface = new Circle();
            shapeInterface.Draw();

            var pizza = GetShape("circle");
            pizza.Draw();

            var e = new MyClass();
            e.Draw();
        }

        static IShape GetShape(string shape)
        {
            if (shape == "circle")
                return new Circle();

            return new Hexagon();
        }
    }

    class Person
    {
        private int Age;
        private string Password;
        private string Name;

        public int GetAge()
        {
            return Age;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
