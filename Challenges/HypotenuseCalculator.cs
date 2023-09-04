using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals.Challenges
{
    public class HypotenuseCalculator
    {
        public HypotenuseCalculator()
        {
            calculateHypotenuse();
        }

        public void calculateHypotenuse()
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();
        }
    }
}
