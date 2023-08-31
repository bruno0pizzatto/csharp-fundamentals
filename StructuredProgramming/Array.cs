namespace csharp_fundamentals.StructuredProgramming
{
    /// <summary>
    ///  array = a variable that can store multiple values. fixed size
    /// </summary>
    public class Array
    {
        void fillArray()
        {
            //String[] cars = {"BMW", "Mustang", "Corvette"};
            String[] cars = new string[3];

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


        }
    }
}
