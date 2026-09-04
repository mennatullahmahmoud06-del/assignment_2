using System;

namespace Session_03
{
    internal class Question14
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            int original = number;
            int reversed = 0;

            // Work with absolute value, handle sign separately
            bool isNegative = number < 0;
            number = Math.Abs(number);

            while (number != 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            if (isNegative)
                reversed = -reversed;

            Console.WriteLine("Reversed: " + reversed);
        }
    }
}
