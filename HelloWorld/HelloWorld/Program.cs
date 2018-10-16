using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Graeme";
            person.Introduce();

            int result = Calculator.Add(1, 2);
            Console.WriteLine("Result: " + result);
        }
    }

    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }
    }

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
