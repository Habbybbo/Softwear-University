using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            GameShoping(balance);
        }

        static void GameShoping(double balance)
        {
            double totalSpend = 0;
            double price = 0;

            while (true)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    break;
                }

                if (game == "OutFall 4")
                {
                    price = 39.99;

                    if (balance >= price)
                    {
                        Console.WriteLine($"Bought {game}");

                        balance -= price;
                        totalSpend += price;
                    }
                    else if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                if (game == "CS: OG")
                {
                    price = 15.99;

                    if (balance >= price)
                    {
                        Console.WriteLine($"Bought {game}");

                        balance -= price;
                        totalSpend += price;
                    }
                    else if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (game == "Zplinter Zell")
                {
                    price = 19.99;

                    if (balance >= price)
                    {
                        Console.WriteLine($"Bought {game}");

                        balance -= price;
                        totalSpend += price;
                    }
                    else if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (game == "Honored 2")
                {
                    price = 59.99;

                    if (balance >= price)
                    {
                        Console.WriteLine($"Bought {game}");

                        balance -= price;
                        totalSpend += price;
                    }
                    else if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (game == "RoverWatch")
                {
                    price = 29.99;

                    if (balance >= price)
                    {
                        Console.WriteLine($"Bought {game}");

                        balance -= price;
                        totalSpend += price;
                    }
                    else if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99;

                    if (balance >= price)
                    {
                        Console.WriteLine($"Bought {game}");

                        balance -= price;
                        totalSpend += price;
                    }
                    else if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (!(game == "RoverWatch Origins Edition" || game == "RoverWatch" || game == "Honored 2" || game == "Zplinter Zell"
                    || game == "CS: OG" || game == "OutFall 4"))
                {
                    Console.WriteLine("Not Found");
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${totalSpend}. Remaining: ${balance:F2}");
        }
    }
}
