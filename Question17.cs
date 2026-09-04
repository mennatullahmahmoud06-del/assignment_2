using System;

namespace Session_03
{
    internal class Question17
    {
        public static void Run()
        {
            Console.Write("Enter x1 y1: ");
            string[] p1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(p1[0]);
            double y1 = double.Parse(p1[1]);

            Console.Write("Enter x2 y2: ");
            string[] p2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(p2[0]);
            double y2 = double.Parse(p2[1]);

            Console.Write("Enter x3 y3: ");
            string[] p3 = Console.ReadLine().Split(' ');
            double x3 = double.Parse(p3[0]);
            double y3 = double.Parse(p3[1]);

            // Three points are collinear if the area of the triangle they form is 0.
            // Area formula (doubled, to avoid division): 
            // x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)
            double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            if (area == 0)
                Console.WriteLine("The points lie on a single straight line.");
            else
                Console.WriteLine("The points do NOT lie on a single straight line.");
        }
    }
}
