using System;

namespace Test
{
    // This is a Vehicle Class
    public class Vehicle
    {
        // Properties that can be accessible 
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; private set; } // Setting private to the set method is an example of encapsulation 
        public void Log()
        {
            Console.WriteLine("the colour is " + Colour + " The make is " + Make + " The models is " + Model + " The price is " + Price);
        }


        // Not letting someone change the price directly
        public void SetPrice(int price)
        {
            Price = price;
        }
    }
}