using System;

namespace Session_03
{
    internal class Question2
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");
        }
    }
}
