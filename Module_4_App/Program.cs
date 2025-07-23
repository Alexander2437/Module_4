using System;
using System.Drawing;

namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Your name letter by letter:");
            
            foreach (var letter in name)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine("The last letter of your name is: {0}", name[^1]);

            Console.ReadKey();
        }
    }
}