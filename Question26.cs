using System;

namespace Session_03
{
    internal class Question26
    {
        public static void Run()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
