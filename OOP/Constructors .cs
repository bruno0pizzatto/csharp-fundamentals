using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals.OOP
{
    public class Constructors
    {
        public Constructors() 
        {
            test();
        }

        public void test()
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Car_c car1 = new Car_c("Ford", "Mustang", 2022, "red");
            Car_c car2 = new Car_c("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }

    class Car_c
    {
        String make;
        String model;
        int year;
        String color;

        public Car_c(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}
