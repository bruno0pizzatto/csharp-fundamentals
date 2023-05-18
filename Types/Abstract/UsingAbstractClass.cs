using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals.Types.Abstract
{
    /// <summary>
    ///  abstract classes =  modifier that indicates missing components or incomplete implementation
    ///      obs: abstract is a key word that applies to classes, methods and properties
    ///      It contains both DECLARATION and DEFINITION of methods
    ///      abstract class does not support multiple inheritance
    /// </summary>
    /// 
    
    internal class UsingAbstractClass
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        //Vehicle vehicle = new Vehicle(); //can't create a vehicle object
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
