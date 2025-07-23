using System;
using System.Drawing;

namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, -2, 35, -16, 18, 35 };

            int counter = 0;

            foreach (int i in arr)
            {
                if (i > 0)
                    counter++;
            }

            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}