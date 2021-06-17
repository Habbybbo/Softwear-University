using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Family familyMembers = new Family();

            for (int i = 0; i < num; i++)
            {
                string[] imputMembers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person member = new Person(imputMembers[0], int.Parse(imputMembers[1]));

                familyMembers.AddMember(member);
            }

            Person oldestMember = familyMembers.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
