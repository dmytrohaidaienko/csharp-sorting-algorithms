using System;
using System.Diagnostics;

namespace SelectionSort_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            Int32[] array = new Int32[] { 22, -12, -20, 9, 5, 11, -23, 0, -4 };

            Console.WriteLine(" Your array: ");
            DisplayArray(in array);

            SelectionSort(ref array, ref sw);

            Console.WriteLine("\n Your array after using SelectionSort algorithm: ");
            DisplayArray(in array);

            Console.WriteLine($"\n Time spent: {sw.Elapsed}");
        }

        static void DisplayArray(in Int32[] array)
        {
            for (Int32 i = 0; i < array.Length; i++)
                Console.Write($" {array[i]} ");
        }

        static void SelectionSort(ref Int32[] array, ref Stopwatch sw)
        {
            sw.Start();
            for (Int32 i = 0; i < array.Length - 1; i++)
            {
                Int32 minIndex = i;
                Int32 temp = 0;
                for (Int32 j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            sw.Stop();
        }
    }
}
