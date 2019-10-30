using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(https?):\/\/(\w.*)\/(\w.*)?";
            
            string sentece = "https://en.wikipedia.org/wiki";
            
            MatchCollection results = Regex.Matches(sentece, pattern);

            PrintURLMatches(results);

            Console.WriteLine("-----------------------------------------------");

            sentece = "http://en.wikipedia.org/wiki/Theoretical_computer_science";

            results = Regex.Matches(sentece, pattern);

            PrintURLMatches(results);

            Console.WriteLine("-----------------------------------------------");

            sentece = "http://en.wikipedia.org/";

            results = Regex.Matches(sentece, pattern);

            PrintURLMatches(results);

        }

        private static void PrintURLMatches(MatchCollection matches)
        {
            foreach (Match match in matches)
            {
                Console.WriteLine($"Protocol => {match.Groups[1].Value}\n" +
                    $"Base URL=> {match.Groups[2].Value}\n" +
                    $"Query String => {match.Groups[3]?.Value}");
            }
        }
    }
}
