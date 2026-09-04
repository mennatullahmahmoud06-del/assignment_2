using System;

namespace Session_03
{
    internal class Question20
    {
        public static void Run()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter " + size + " elements:");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }

            Console.WriteLine("Sum of all elements = " + sum);
        }
    }
}
