using System;

namespace Projet_Test
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Bitch!");


            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Random random = new Random();
            int stupidityPercentage = random.Next(0, 101);

            Console.WriteLine($"Damn {userName}, your name sounds {stupidityPercentage}% stupid.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
