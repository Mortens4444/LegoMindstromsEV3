using System;
using System.Threading;

namespace Mindstorms.CLI
{
    internal class Program
    {
        private static readonly CommandExecutor commandExecutor = new CommandExecutor();

        static void Main()
        {
            var processCommand = true;
            Console.WriteLine("Type 'help' for more information.");
            while (processCommand)
            {
                var command = Console.ReadLine();
                commandExecutor.Execute(command);

                Thread.Sleep(100);
            }
        }
    }
}
