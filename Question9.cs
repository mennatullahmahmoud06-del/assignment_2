using System;

namespace Session_03
{
    internal class Question9
    {
        public static void Run()
        {
            Console.Write("Enter base and exponent separated by a space: ");
            string[] parts = Console.ReadLine().Split(' ');

            int baseNum = int.Parse(parts[0]);
            int exponent = int.Parse(parts[1]);

            long result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine(result);
        }
    }
}
