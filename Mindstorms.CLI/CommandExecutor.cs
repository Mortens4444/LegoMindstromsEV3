using Mindstorms.CLI.Commands;
using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Utils;

namespace Mindstorms.CLI
{
    internal class CommandExecutor
    {
        private Brick brick;
        private readonly List<ICliCommand> commands = new List<ICliCommand>();
        private const string CommandsNamespace = "Mindstorms.CLI.Commands";

        public CommandExecutor()
        {
            RegisterCommands();
        }

        private void RegisterCommands()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypesInNamespace(CommandsNamespace);
            var classes = types.Where(type => type.IsClass).ToList();
            foreach (var @class in classes)
            {
                var command = (ICliCommand)Activator.CreateInstance(@class);
                commands.Add(command);
            }
        }

        public void Execute(string command)
        {
            try
            {
                var commandParts = command.Split(' ');
                var commandName = commandParts[0];
                var commandToExecute = commands.FirstOrDefault(cmd => String.Equals(cmd.Name, commandName, StringComparison.OrdinalIgnoreCase));
                
                if (commandToExecute != null)
                {
                    commandToExecute.Action(ref brick, commandParts.Skip(1));
                }
                else
                {
                    Console.Error.WriteLine("Command not found");
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"{ex.GetType()} - {ex.Message}");
            }
        }
    }
}