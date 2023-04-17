using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.CLI.Commands
{
    internal class Connect : ICliCommand
    {
        public string Name => nameof(Connect);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            var args = arguments.ToList();
            brick = args.Count == 1 ? new Brick(args[0]) : new Brick(args[0], args[1]);
            brick.Connect();
            Console.WriteLine("Succesfully connected.");
        }
    }
}
