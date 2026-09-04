using System;

namespace Session_03
{
    internal class Question15
    {
        public static void Run()
        {
            Console.Write("Input starting number of range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime number between " + start + " and " + end + " are :");

            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
