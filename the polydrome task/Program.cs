using System;
namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'q', 'w', 'e', 'w', 'q' };
            if (IsPalindrom(arr))
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
        }

        static bool IsPalindrom(char[] word)
        {
            for (int i = 0; i < word.Length / 2; i++)
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            return true;
        }
    }