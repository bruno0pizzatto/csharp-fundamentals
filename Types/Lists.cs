using System.Collections.Generic;

namespace csharp_fundamentals.Types
{
    /// <summary>
    ///  List = data structure that represents a list of objects that can be accessed by index.
    ///  Similar to array, but can dynamically increase/decrease in size 
    /// </summary>
    public class Lists
    {
        public Lists()
        {
            testLists();
        }

        public void testLists()
        {
            String[] foodArray = new string[3];

            foodArray[0] = "pizza";
            foodArray[1] = "hamburger";
            foodArray[2] = "hotdog";

            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //Console.WriteLine(food[0]);
            //Console.WriteLine(food[1]);
            //Console.WriteLine(food[2]);
            //Console.WriteLine(food[3]);

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    } 
}
