using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animal = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] food = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string foodType = food[0];
                int foodQuantity = int.Parse(food[1]);

                if (animal[0] == "Cat" || animal[0] == "Tiger")
                {
                    string type = animal[0];
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    string livingRegion = animal[3];
                    string breed = animal[4];

                    if (type == "Cat")
                    {
                        Cat cat = new Cat(type, name, weight, livingRegion, breed);
                        cat.FeedMe();

                        if (foodType == "Vegetable" || foodType == "Meat")
                        {
                            cat.Weight += foodQuantity * 0.30;
                            cat.FoodEaten = foodQuantity;
                        }
                        else
                        {
                            Console.WriteLine($"{type} does not eat {foodType}!");
                        }

                        animals.Add(cat);
                    }
                    else if (type == "Tiger")
                    {
                        Tiger tiger = new Tiger(type, name, weight, livingRegion, breed);
                        tiger.FeedMe();

                        if (foodType == "Meat")
                        {
                            tiger.Weight += foodQuantity * 1.00;
                            tiger.FoodEaten = foodQuantity;
                        }
                        else
                        {
                            Console.WriteLine($"{type} does not eat {foodType}!");
                        }

                        animals.Add(tiger);
                    }
                }
                else if (animal[0] == "Hen" || animal[0] == "Owl")
                {
                    string type = animal[0];
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    double wingSize = double.Parse(animal[3]);

                    if (type == "Hen")
                    {
                        Hen hen = new Hen(type, name, weight, wingSize);
                        hen.FeedMe();

                        hen.Weight += foodQuantity * 0.35;
                        hen.FoodEaten = foodQuantity;

                        animals.Add(hen);
                    }
                    else if (type == "Owl")
                    {
                        Owl owl = new Owl(type, name, weight, wingSize);
                        owl.FeedMe();

                        if (foodType == "Meat")
                        {
                            owl.Weight += foodQuantity * 0.25;
                            owl.FoodEaten = foodQuantity;
                        }
                        else
                        {
                            Console.WriteLine($"{type} does not eat {foodType}!");
                        }

                        animals.Add(owl);
                    }
                }
                else if (animal[0] == "Mouse" || animal[0] == "Dog")
                {
                    string type = animal[0];
                    string name = animal[1];
                    double weight = double.Parse(animal[2]);
                    string livingRegion = animal[3];

                    if (type == "Mouse")
                    {
                        Mouse mouse = new Mouse(type, name, weight, livingRegion);
                        mouse.FeedMe();

                        if (foodType == "Vegetable" || foodType == "Fruit")
                        {
                            mouse.Weight += foodQuantity * 0.10;
                            mouse.FoodEaten = foodQuantity;
                        }
                        else
                        {
                            Console.WriteLine($"{type} does not eat {foodType}!");
                        }

                        animals.Add(mouse);
                    }
                    else if (type == "Dog")
                    {
                        Dog dog = new Dog(type, name, weight, livingRegion);
                        dog.FeedMe();

                        if (foodType == "Meat")
                        {
                            dog.Weight += foodQuantity * 0.40;
                            dog.FoodEaten = foodQuantity;
                        }
                        else
                        {
                            Console.WriteLine($"{type} does not eat {foodType}!");
                        }

                        animals.Add(dog);
                    }
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
