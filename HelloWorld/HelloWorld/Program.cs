namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Spring;

            switch (season)
            {
                case Season.Spring:
                case Season.Summer:
                    System.Console.WriteLine("It's spring or summer.");
                    break;
                case Season.Autumn:
                    System.Console.WriteLine("It's autumn.");
                    break;
                case Season.Winter:
                    System.Console.WriteLine("It's winter.");
                    break;
                default:
                    System.Console.WriteLine("I don't understand that season.");
                    break;
            }
        }
    }
}
