using System;

namespace Session_03
{
    internal class Question28
    {
        public static void Run()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter " + size + " elements:");
            for (int i = 0; i < size; i++)
                array[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Array in reverse order:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
