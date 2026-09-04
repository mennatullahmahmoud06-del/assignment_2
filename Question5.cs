using System;

namespace Session_03
{
    internal class Question5
    {
        public static void Run()
        {
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadLine()[0]);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("Consonant");
        }
    }
}
