using System;
using System.Diagnostics;

namespace BubbleSort_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            Int32[] array = new Int32[] { 14, 8, 1, 99, 65, 0, -23, 19, -1 };

            Console.WriteLine(" Your array: ");
            DisplayArray(in array);

            BubbleSort(ref array, ref sw);

            Console.WriteLine("\n Your array after using BubbleSort algorithm: ");
            DisplayArray(in array);

            Console.WriteLine($"\n Time spent: {sw.Elapsed}");
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.Write($" {array[i]} ");
        }

        static void BubbleSort(ref Int32[] array, ref Stopwatch sw)
        {
            Int32 temp = 0;

            sw.Start();
            for (Int32 i = 0; i < array.Length; i++)
            {
                for (Int32 j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            sw.Stop();
        }
    }
}
