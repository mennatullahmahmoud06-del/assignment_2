using System;

namespace Session_03
{
    internal class Question6
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i != n)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
