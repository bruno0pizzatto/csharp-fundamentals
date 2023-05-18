namespace csharp_fundamentals.StructuredProgramming
{
    /// <summary>
    ///  while loop = repeats some code while some condition remains true
    /// </summary>
    internal class WhileLoopStatment
    {

        void enterYourName()
        {
            string? name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }

        void infiniteLoop()
        {
            while (true)
            {
                Console.WriteLine("HELP! I'm STUCK IN AN INFINITE LOOP!!!");
            }
        }
    }
}
