using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Graeme Erickson";
            var numbers = new int[] { 1, 2, 3, 4 };

            //for (var i = 0; i < name.Length; i++)
                //Console.WriteLine(name[i]);

            foreach (var character in name)
                Console.WriteLine(character);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
