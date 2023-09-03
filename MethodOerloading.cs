using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals
{
    public class MethodOerloading
    {
        public MethodOerloading() 
        {
            test();
        }

        public void test()
        {
            // method overloading  = methods share same name, but different parameters
            //                       name + parameters = signature
            //                       methods must have a unique signature

            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadKey();
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
