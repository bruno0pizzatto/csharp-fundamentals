using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals.Types.Interfaces
{
    /// <summary>
    ///  interface = defines a "contract" that all the classes inheriting from should follow
    ///  
    ///  An interface declares "what a class should have"
    ///  An inheriting class defines "how it should do it"
    ///  
    ///  benefits = security + multiple inheritance + "plug-and-play"
    /// </summary>
    internal class UsingInterface
    {
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        //rabbit.Flee();
        //hawk.Hunt();
        //fish.Flee();
        //fish.Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee() 
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }

    class Hawk : IPredator 
    { 
        public void Hunt() 
        {
            Console.WriteLine("The Hawk is searching for food!");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee() 
        {
            Console.WriteLine("The fish runs away!");
        }
        public void Hunt() 
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }
}
