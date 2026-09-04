using System;

namespace Session_03
{
    internal class Question18
    {
        public static void Run()
        {
            Console.Write("Enter time taken (in hours): ");
            double hours = double.Parse(Console.ReadLine());

            if (hours >= 2 && hours <= 3)
                Console.WriteLine("Highly efficient.");
            else if (hours > 3 && hours <= 4)
                Console.WriteLine("Instructed to increase their speed.");
            else if (hours > 4 && hours <= 5)
                Console.WriteLine("Provided with training to enhance their speed.");
            else if (hours > 5)
                Console.WriteLine("Required to leave the company.");
            else
                Console.WriteLine("Invalid time entered.");
        }
    }
}
