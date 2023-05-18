namespace csharp_fundamentals.StructuredProgramming
{
    /// <summary>
    /// nested loops = loops inside of other loops
    /// Uses vary. Used a lot in sorting algorithms
    /// </summary>
    internal class NestedLoops
    {
        void nestedLoops()
        {
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String? symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
