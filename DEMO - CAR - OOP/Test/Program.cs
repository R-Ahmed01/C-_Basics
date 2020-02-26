using System.Collections.Generic;

namespace Test
{
    /* Todo
           Exercise 1: Creating an object COMPLETE

               a) instantiate object - done
               b) assign properties - done
               c) print properties out to console. - done

           Excercise 2: Inheritance

               a) Create a super / base class.
               b) Inherit from this class... does it build?
               c) move properties to base class
               d) make sure exercise 1 still works.

           Exercise 3)

               a) Demonstrate encapsulation

           Exercise 4)

               a) demonstrate polymophism

           */

    class Program
    {
        static void Main(string[] args)
        {
            // This is where all the objects are created


            Mercedes mercedes = new Mercedes();
            mercedes.SetPrice(10000);
            mercedes.Log();

            Ford ford = new Ford();
            ford.SetPrice(2030);
            ford.Log();

            // This is polymorphism
            
            List<Vehicle> vehicles = new List<Vehicle>
            {
                mercedes, ford
            };

            // it does not matter what type it is but List<> should 

            foreach (var car in vehicles)
            {
                car.Log();
            }   
        }
    }
    

  


}


