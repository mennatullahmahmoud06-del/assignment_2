using System;

namespace Session_03
{
    internal class Question7
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(n * i);
                if (i != 12)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
