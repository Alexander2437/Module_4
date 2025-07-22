using System;
using System.Drawing;

namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Iteration {0}", i);

                var text = Console.ReadLine();

                if (text == "stop")
                {
                    Console.WriteLine("The cycle is stopped.");
                    break;
                }

                switch (text)
                {
                    case "white":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your colour is white!");
                        break;
                    case "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is blue!");
                        break;
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your colour is red!");
                        break;
                    default:
                        continue;
                }
            }

            Console.ReadKey();
        }
    }
}