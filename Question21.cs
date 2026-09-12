using System;

namespace Session_03
{
    internal class Question21
    {
        public static void Run()
        {
            Console.Write("Enter size of each array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            Console.WriteLine("Enter " + size + " elements for the first array (ascending order):");
            for (int i = 0; i < size; i++)
                array1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + size + " elements for the second array (ascending order):");
            for (int i = 0; i < size; i++)
                array2[i] = int.Parse(Console.ReadLine());

            int[] merged = new int[size * 2];
            int i1 = 0, i2 = 0, k = 0;

            while (i1 < size && i2 < size)
            {
                if (array1[i1] <= array2[i2])
                    merged[k++] = array1[i1++];
                else
                    merged[k++] = array2[i2++];
            }

            while (i1 < size)
                merged[k++] = array1[i1++];

            while (i2 < size)
                merged[k++] = array2[i2++];

            Console.WriteLine("Merged array:");
            Console.WriteLine(string.Join(" ", merged));
        }
    }
}
