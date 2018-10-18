using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input != "q")
            {
                Console.WriteLine("Enter a number between 1 and 10, or enter 'q' to quit:");
                input = Console.ReadLine();
                if (input == "q")
                {
                    Console.WriteLine("Exiting...");
                    return;
                }

                if (Convert.ToInt16(input) > 0 && Convert.ToInt16(input) < 11)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
        }
    }
}
