using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals.StructuredProgramming
{
    public class ForEachLoopStatment
    {
        public ForEachLoopStatment()
        {
            test();
        }

        public void test()
        {
            // foreach loop = a simpler way to iterate over an array, but it's less flexible

            String[] cars = { "BMW", "Mustang", "Corvette" };

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
