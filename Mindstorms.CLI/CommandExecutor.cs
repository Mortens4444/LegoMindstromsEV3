using Mindstorms.CLI.Commands;
using Mindstorms.Core.EV3;
using System.Reflection;

namespace Mindstorms.CLI;

internal class CommandExecutor
{
    private Brick? brick;
    private readonly List<ICliCommand> commands = new();

    public CommandExecutor()
    {
        RegisterCommands();
    }

    private void RegisterCommands()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();
        var commandClasses = types.Where(type => type.IsClass && typeof(ICliCommand).IsAssignableFrom(type)).ToList();

        foreach (var commandClass in commandClasses)
        {
            var command = Activator.CreateInstance(commandClass) as ICliCommand;
            commands.Add(command!);
        }
    }

    public void Execute(string command)
    {
        try
        {
            var commandParts = command.Split(' ');
            var commandName = commandParts[0];
            var commandToExecute = commands.FirstOrDefault(cmd => String.Equals(cmd.Name, commandName, StringComparison.OrdinalIgnoreCase)
                || cmd.Aliases.Contains(commandName.ToLower()));
            
            if (commandToExecute != null)
            {
                commandToExecute.Action(ref brick, commandParts.Skip(1).ToList());
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