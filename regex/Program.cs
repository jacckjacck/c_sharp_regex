using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\w*\,?\s?)";
            Console.WriteLine("Enter a sentece");
            string sentece = Console.ReadLine();
            var words = Regex.Split(sentece, pattern);
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
