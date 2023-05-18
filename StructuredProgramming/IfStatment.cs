namespace csharp_fundamentals.StructuredProgramming
{
    /// <summary>
    ///  if statement = a basic form of decision making
    /// </summary>
    public class IfStatment
    {
        void checkName(string name)
        {
            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }

            Console.ReadKey();
        }

        void checkAge(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if(age > 100)
            {
                Console.WriteLine("You are too old to signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't born yet!");
            }
            else
            {
                Console.WriteLine("Somenthing happened to enter here =P");
            }
        }

    }
}
