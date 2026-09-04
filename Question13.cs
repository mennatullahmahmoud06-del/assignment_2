using System;

namespace Session_03
{
    internal class Question13
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine("Reversed: " + reversed);
        }
    }
}
