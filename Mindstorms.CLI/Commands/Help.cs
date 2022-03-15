using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mindstorms.CLI.Commands
{
    internal class Help : ICliCommand
    {
        public string Name => nameof(Help);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            var lines = File.ReadAllLines("Commands.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
