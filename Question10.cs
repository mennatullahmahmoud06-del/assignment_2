using System;

namespace Session_03
{
    internal class Question10
    {
        public static void Run()
        {
            Console.Write("Enter Marks of five subjects: ");
            string[] parts = Console.ReadLine().Split(' ');

            int total = 0;
            foreach (string mark in parts)
            {
                total += int.Parse(mark);
            }

            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Percentage = " + percentage);
        }
    }
}
