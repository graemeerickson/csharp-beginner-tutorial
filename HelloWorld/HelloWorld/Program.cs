using System;

namespace HelloWorld
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter speed of the car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            bool isSpeeding = carSpeed > speedLimit;

            if (!isSpeeding)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}
