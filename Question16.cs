using System;

namespace Session_03
{
    internal class Question16
    {
        public static void Run()
        {
            Console.Write("Enter a number to convert: ");
            int number = int.Parse(Console.ReadLine());

            int original = number;
            string binary = "";

            if (number == 0)
            {
                binary = "0";
            }

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary; // Prepend, since remainders come out least-significant first
                number /= 2;
            }

            Console.WriteLine("The Binary of " + original + " is " + binary + ".");
        }
    }
}
