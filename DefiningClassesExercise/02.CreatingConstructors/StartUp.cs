using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person maina = new Person();
            Person bace = new Person(24);
            Person chicoPencho = new Person("Chicho Pencho", 65);

            Console.WriteLine($"{maina.Name} - {maina.Age}");
            Console.WriteLine($"{bace.Name} - {bace.Age}");
            Console.WriteLine($"{chicoPencho.Name} - {chicoPencho.Age}");
        }
    }
}
