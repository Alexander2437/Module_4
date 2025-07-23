using System;
using System.Drawing;

namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);

            Console.ReadKey();

            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
        }
    }
}