﻿using CommandPattern.Core.Contracts;
using CommandPattern.Core.Models.Commands;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string commandSuffix = "Command";
        public string Read(string args)
        {
            string[] tokens = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string commandName = tokens[0];
            string[] commandArgs = tokens[1..];

            //ICommand command = default;
            //if (commandName == "Hello")
            //{
            //    command = new HelloCommand();

            //}
            //else if (commandName == "Exit")
            //{
            //    command = new ExitCommand();
            //}

            Type commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == $"{commandName}{commandSuffix}");

            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            string result = command.Execute(commandArgs);

            return result;
        }
    }
}
