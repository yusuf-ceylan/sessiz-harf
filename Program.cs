using System;

namespace sessiz_harf
{
    class Program
    {
        static bool IsConsonant(char c)
        {
            char[] consonants = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };
            return Array.Exists(consonants, x => x == char.ToLower(c));
        }

        static bool CheckForConsecutive(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (IsConsonant(text[i]) && IsConsonant(text[i + 1]))
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Metninizi girin: ");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');

            foreach (var item in inputArray)
            {
                bool result = CheckForConsecutive(item);
                Console.Write(result ? "True " : "False ");
            }
        }
    }
}
