using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var graeme = new Person();
            graeme.FirstName = "Graeme";
            graeme.LastName = "Erickson";
            graeme.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine("Result: " + result);
        }
    }
}
