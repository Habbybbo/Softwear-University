using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _2.EmojieDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiesPatern = @"([::\*\*]{2})(?<emojis>[A-Z][a-z]{2,})\1";
            string thresholdPatern = @"(?<threshold>\d)";

            string text = Console.ReadLine();

            MatchCollection emojiesRegex = Regex.Matches(text, emojiesPatern);
            var thresholdRegex = Regex.Matches(text, thresholdPatern);

            int emojiesCount = emojiesRegex.Count;
            long thresholdSum = 1;
            

            foreach (Match number in thresholdRegex)
            {
                thresholdSum *= int.Parse(number.Value);
            }

            Console.WriteLine($"Cool threshold: {thresholdSum}");
            Console.WriteLine($"{emojiesCount} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojiesRegex)
            {
                long emojiSum = 0;

                var name = emoji.Groups["emojis"].Value;

                for (int i = 0; i < name.Length; i++)
                {
                    char currentChar = name[i];
                    emojiSum += (int)currentChar;
                }

                if (emojiSum >= thresholdSum)
                {
                    Console.WriteLine(emoji.Value);
                }
            }

        }
    }
}
