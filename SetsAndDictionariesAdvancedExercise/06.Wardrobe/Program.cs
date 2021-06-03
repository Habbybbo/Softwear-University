using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Replace(" -> ",",").Split(',', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 1; j <= input.Length - 1; j++)
                {
                    string color = input[0];
                    string dress = input[j];

                    if (wardrobe.ContainsKey(color))
                    {
                        if (wardrobe[color].ContainsKey(dress))
                        {
                            wardrobe[color][dress]++;
                        }
                        else
                        {
                            wardrobe[color].Add(dress, 1);
                        }
                    }
                    else
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                        wardrobe[color].Add(dress, 1);
                    }
                }
            }

            string[] finalInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var dress in color.Value)
                {
                    if (finalInput[0] == color.Key && finalInput[1] == dress.Key)
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {dress.Key} - {dress.Value}");
                }
            }
        }
    }
}
