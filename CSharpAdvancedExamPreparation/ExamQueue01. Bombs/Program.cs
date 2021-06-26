using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamQueue01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffectsInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bombCasingInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            SortedDictionary<string, int> bombPouch = new SortedDictionary<string, int>();

            bombPouch.Add("Datura Bombs", 0);
            bombPouch.Add("Cherry Bombs", 0);
            bombPouch.Add("Smoke Decoy Bombs", 0);

            Queue<int> bombEffects = new Queue<int>(bombEffectsInput);
            Stack<int> bombCasing = new Stack<int>(bombCasingInput);

            int shortestInput = 0;

            if (bombEffects.Count > bombCasing.Count)
            {
                shortestInput = bombCasing.Count;
            }
            else
            {
                shortestInput = bombEffects.Count;
            }

            //•	Datura Bombs: 40
            //•	Cherry Bombs: 60
            //•	Smoke Decoy Bombs: 120

            bool bombPouchIsFilled = false;

            for (int i = shortestInput; i > 0; i = bombCasing.Count)
            {
                int currentBombEfectsNum = bombEffects.Peek();
                int currentBombCasingNum = bombCasing.Peek();

                int numSum = currentBombEfectsNum + currentBombCasingNum;

                if (numSum == 40)
                {
                    if (bombPouch.ContainsKey("Datura Bombs"))
                    {
                        bombPouch["Datura Bombs"]++;
                    }
                    //else
                    //{
                    //    bombPouch.Add("Datura Bombs", 1);
                    //}

                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (numSum == 60)
                {
                    if (bombPouch.ContainsKey("Cherry Bombs"))
                    {
                        bombPouch["Cherry Bombs"]++;
                    }
                    //else
                    //{
                    //    bombPouch.Add("Cherry Bombs", 1);
                    //}

                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (numSum == 120)
                {
                    if (bombPouch.ContainsKey("Smoke Decoy Bombs"))
                    {
                        bombPouch["Smoke Decoy Bombs"]++;
                    }
                    //else
                    //{
                    //    bombPouch.Add("Smoke Decoy Bombs", 1);
                    //}

                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else
                {
                    currentBombCasingNum -= 5;
                    bombCasing.Pop();
                    bombCasing.Push(currentBombCasingNum);
                }

                if (bombPouch.ContainsKey("Datura Bombs"))
                {
                    if (bombPouch["Datura Bombs"] >= 3)
                    {
                        if (bombPouch.ContainsKey("Cherry Bombs"))
                        {
                            if (bombPouch["Cherry Bombs"] >= 3)
                            {
                                if (bombPouch.ContainsKey("Smoke Decoy Bombs"))
                                {
                                    if (bombPouch["Smoke Decoy Bombs"] >= 3)
                                    {
                                        bombPouchIsFilled = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                
            }

            if (bombPouchIsFilled == true)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }

            if (bombCasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }

            foreach (var bomb in bombPouch)
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
