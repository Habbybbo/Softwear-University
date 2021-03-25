using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> commands = new List<string>();

            while (true)
            {
                string consoleImput = Console.ReadLine();

                if (consoleImput == "end")
                {
                    break;
                }

                List<string> commandList = consoleImput.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                

                if (commandList[0] == "Chat")
                {
                    commands.Add(commandList[1]);
                }

                if (commandList[0] == "Delete")
                {
                    commands.Remove(commandList[1]);
                }

                
                if (commandList[0] == "Edit")
                {
                    commands.Remove(commandList[1]);
                }

                if (commandList[0] == "Pin")
                {
                    string pinMessage = commandList[1];
                    commands.Remove(pinMessage);
                    commands.Add(pinMessage);
                }

                if (commandList[0] == "Spam")
                {
                    List<string> messagesColection = commandList;
                    messagesColection.RemoveAt(0);
                    commands.AddRange(messagesColection);
                }

                
            }

            foreach (var item in commands)
            {
                Console.WriteLine(item);
            }


        }
    }
}
