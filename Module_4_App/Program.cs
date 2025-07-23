using System;
using System.Drawing;

namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert your name: ");
            string? name = Console.ReadLine();
            Console.Write("Your name inverted: ");
            
            for (int i = name.Length; i > 0; i--) // Как вариант for (int i = name.Length - 1; i >= 0; i--) => Console.Write(name[i] + " ")
                Console.Write(name[i - 1] + " ");

            Console.ReadKey();
        }
    }
}