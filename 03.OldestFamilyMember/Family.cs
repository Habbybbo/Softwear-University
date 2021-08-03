using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {

        private Dictionary<string, int> familyMembers;

        public Family()
        {
            this.familyMembers = new Dictionary<string, int>();
        }
        public Family(string name, int age)
        {

        }

        public void AddMember(Person member)
        {
            familyMembers.Add(member.Name, member.Age);

        }

        public Person GetOldestMember()
        {
            Person oldestMember = new Person();

            foreach (var person in familyMembers)
            {
                if (person.Value >= oldestMember.Age)
                {
                    oldestMember.Name = person.Key;
                    oldestMember.Age = person.Value;
                }
            }

            return oldestMember;
        }
    }
}
