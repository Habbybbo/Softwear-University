using System;
using System.Linq;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Contains":
                        {
                            if (activationKey.Contains(tokens[1]))
                            {
                                Console.WriteLine($"{activationKey} contains {tokens[1]}");
                            }
                            else
                            {
                                Console.WriteLine($"Substring not found!");
                            }
                            break;
                        }
                    case "Flip":
                        {
                            if (tokens[1] == "Upper")
                            {
                                string uppperString = activationKey.Substring(int.Parse(tokens[2]), int.Parse(tokens[3]) - int.Parse(tokens[2]))
                                    .ToUpper();
                                activationKey = activationKey.Remove(int.Parse(tokens[2]), int.Parse(tokens[3]) - int.Parse(tokens[2]));
                                activationKey = activationKey.Insert(int.Parse(tokens[2]), uppperString);

                            }
                            else if (tokens[1] == "Lower")
                            {
                                string uppperString = activationKey.Substring(int.Parse(tokens[2]), int.Parse(tokens[3]) - int.Parse(tokens[2]))
                                    .ToLower();
                                activationKey = activationKey.Remove(int.Parse(tokens[2]), int.Parse(tokens[3]) - int.Parse(tokens[2]));
                                activationKey = activationKey.Insert(int.Parse(tokens[2]), uppperString);
                            }

                            Console.WriteLine(activationKey);
                            break;
                        }
                    case "Slice":
                        {
                            activationKey = activationKey.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]) - int.Parse(tokens[1]));

                            Console.WriteLine(activationKey);
                            break;
                        }
                }



                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
