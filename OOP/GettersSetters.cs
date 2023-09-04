using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals.OOP
{
    public class GettersSetters
    {
        public GettersSetters() 
        {
            test();
        }

        public void test()
        {
            //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            Car1 car = new Car1(400);

            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }

    class Car1
    {
        private int speed;

        public Car1(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
