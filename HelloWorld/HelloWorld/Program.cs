using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine("number: " + number); // number: 1

            var person = new Person() {Age = 20};
            MakeOld(person);
            Console.WriteLine("age: " + person.Age); // age: 30
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
