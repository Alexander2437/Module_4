using System;
using System.Drawing;

namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском языке с маленькой буквы:");

            var color = Console.ReadLine();

            switch (color)
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
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Wrong! Reconsider your oppinion! =)");
                    break;
            }

            Console.ReadKey();
        }
    }
}