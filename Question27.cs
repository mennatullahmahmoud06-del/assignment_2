using System;

namespace Session_03
{
    internal class Question27
    {
        public static void Run()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] array1 = new int[rows, cols];
            int[,] array2 = new int[rows, cols];

            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Element [" + i + "," + j + "]: ");
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copy all elements from array1 to array2
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array2[i, j] = array1[i, j];
                }
            }

            Console.WriteLine("Second array (copied):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
