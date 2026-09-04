using System;

namespace Session_03
{
    internal class Question3
    {
        public static void Run()
        {
            Console.Write("Enter 3 integers separated by spaces: ");
            string[] parts = Console.ReadLine().Split(' ');

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);

            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine("max element = " + max);
            Console.WriteLine("min element = " + min);
        }
    }
}
