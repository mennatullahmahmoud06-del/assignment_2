using System;

namespace Session_03
{
    internal class Question19
    {
        public static void Run()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((i == j ? 1 : 0) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
