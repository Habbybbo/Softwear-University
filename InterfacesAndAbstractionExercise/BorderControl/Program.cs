using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            int inputPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputPeople; i++)
            {
                string[] people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (people.Length == 4)
                {
                    string name = people[0];
                    int age = int.Parse(people[1]);
                    string id = people[2];
                    string birthdate = people[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);

                    citizens.Add(citizen);
                }
                else if (people.Length == 3)
                {
                    string name = people[0];
                    int age = int.Parse(people[1]);
                    string group = people[2];

                    Rebel rebel = new Rebel(name, age, group);

                    rebels.Add(rebel);
                }
            }

            string input = string.Empty;

            int tottalFood = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var person in citizens)
                {
                    if (person.Name == input)
                    {
                        person.BuyFood();

                        tottalFood += person.Food;
                    }
                }

                foreach (var rebel in rebels)
                {
                    if (rebel.Name == input)
                    {
                        rebel.BuyFood();

                        tottalFood += rebel.Food;
                    }
                }
            }

            Console.WriteLine(tottalFood);
        }
    }
}
