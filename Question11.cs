using System;

namespace Session_03
{
    internal class Question11
    {
        public static void Run()
        {
            Console.Write("Enter Month Number: ");
            int month = int.Parse(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28;
                    break;
                default:
                    days = -1;
                    break;
            }

            if (days == -1)
                Console.WriteLine("Invalid month number.");
            else
                Console.WriteLine("Days in Month: " + days);
        }
    }
}
