namespace Mindstorms.CLI;

internal class Program
{
    private static readonly CommandExecutor commandExecutor = new();

    static void Main()
    {
        var processCommand = true;
        Console.WriteLine("Type 'help', '?', 'h' or 'examples' for more information.");
        while (processCommand)
        {
            var command = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(command))
            {
                commandExecutor.Execute(command);
            }

            Thread.Sleep(100);
        }
    }
}
