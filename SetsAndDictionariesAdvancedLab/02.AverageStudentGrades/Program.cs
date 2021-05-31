using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < num; i++)
            {
                string[] student = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = student[0];
                decimal grade = decimal.Parse(student[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<decimal>() { grade });
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(' ', student.Value).ToString():F2} (avg: {student.Value.Average():F2})");
            }
        }
    }
}
