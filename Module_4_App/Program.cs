using System;
using System.Drawing;

namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int[] arrIndex in array)
            {
                foreach (int numIndex in arrIndex)
                {
                    Console.Write(numIndex + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}