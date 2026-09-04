using System;

namespace Session_03
{
    internal class Question24
    {
        public static void Run()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter " + size + " elements:");
            for (int i = 0; i < size; i++)
                array[i] = int.Parse(Console.ReadLine());

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int element in array)
            {
                if (element > largest)
                {
                    secondLargest = largest;
                    largest = element;
                }
                else if (element > secondLargest && element != largest)
                {
                    secondLargest = element;
                }
            }

            Console.WriteLine("Second largest element = " + secondLargest);
        }
    }
}
