using System;

namespace Session_03
{
    internal class Question1
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
