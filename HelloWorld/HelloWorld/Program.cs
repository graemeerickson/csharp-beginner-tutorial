using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            var max = (input1 > input2) ? input1 : input2;
            Console.WriteLine("Max number: " + max);
        }
    }
}
