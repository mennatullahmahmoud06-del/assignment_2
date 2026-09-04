using System;

namespace Session_03
{
    internal class Question23
    {
        public static void Run()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter " + size + " elements:");
            for (int i = 0; i < size; i++)
                array[i] = int.Parse(Console.ReadLine());

            int max = array[0];
            int min = array[0];

            foreach (int element in array)
            {
                if (element > max) max = element;
                if (element < min) min = element;
            }

            Console.WriteLine("Maximum element = " + max);
            Console.WriteLine("Minimum element = " + min);
        }
    }
}
