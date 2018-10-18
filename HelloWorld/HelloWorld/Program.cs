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
            Console.WriteLine("Enter image width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter image height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation: " + orientation);
        }
    }
}
