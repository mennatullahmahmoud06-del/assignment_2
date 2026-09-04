using System;
using System.Collections.Generic;

namespace Session_03
{
    internal class Question22
    {
        public static void Run()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter " + size + " elements:");
            for (int i = 0; i < size; i++)
                array[i] = int.Parse(Console.ReadLine());

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int element in array)
            {
                if (frequency.ContainsKey(element))
                    frequency[element]++;
                else
                    frequency[element] = 1;
            }

            foreach (var pair in frequency)
            {
                Console.WriteLine(pair.Key + " occurs " + pair.Value + " time(s)");
            }
        }
    }
}
