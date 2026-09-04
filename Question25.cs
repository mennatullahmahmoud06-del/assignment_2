using System;
using System.Collections.Generic;

namespace Session_03
{
    internal class Question25
    {
        public static void Run()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter " + size + " elements:");
            for (int i = 0; i < size; i++)
                array[i] = int.Parse(Console.ReadLine());

            // For each value, remember the first index where it appeared.
            Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            int longestDistance = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (!firstIndex.ContainsKey(array[i]))
                {
                    firstIndex[array[i]] = i;
                }
                else
                {
                    // Distance = number of cells BETWEEN the two equal cells
                    int distance = i - firstIndex[array[i]] - 1;
                    if (distance > longestDistance)
                        longestDistance = distance;
                }
            }

            Console.WriteLine("Longest distance = " + longestDistance);
        }
    }
}
