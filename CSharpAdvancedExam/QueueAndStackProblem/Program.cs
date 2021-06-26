using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueAndStackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputQueueData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            byte[] inputStackData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();

            Queue<int> ingredients = new Queue<int>(inputQueueData);
            Stack<byte> freshness = new Stack<byte>(inputStackData);

            SortedDictionary<string, byte> dishes = new SortedDictionary<string, byte>();

            dishes.Add("Dipping sauce", 0);
            dishes.Add("Green salad", 0);
            dishes.Add("Chocolate cake", 0);
            dishes.Add("Lobster", 0);

            
            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                
                int curentNumSum = ingredients.Peek() * freshness.Peek();

                if (curentNumSum == 150)
                {
                    CheckingForDish(dishes, "Dipping sauce");

                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (curentNumSum == 250)
                {
                    CheckingForDish(dishes, "Green salad");

                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (curentNumSum == 300)
                {
                    CheckingForDish(dishes, "Chocolate cake");

                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (curentNumSum == 400)
                {
                    CheckingForDish(dishes, "Lobster");

                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    int curentIngredientNum = ingredients.Peek() + 5;
                    ingredients.Dequeue();
                    ingredients.Enqueue(curentIngredientNum);
                }

                if (ingredients.Count() > 0 && ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                }

            }

            byte neededDishes = 0;

            foreach (var item in dishes)
            {
                if (item.Value > 0)
                {
                    neededDishes++;
                }
            }

            if (neededDishes == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var dish in dishes)
            {
                if (dish.Value > 0)
                {
                    Console.WriteLine($"# {dish.Key} --> {dish.Value}");
                }
                
            }
        }

        private static void CheckingForDish(SortedDictionary<string, byte> dishes, string dish)
        {
            if (dishes.ContainsKey(dish))
            {
                dishes[dish]++;
            }
            
        }
    }
}
