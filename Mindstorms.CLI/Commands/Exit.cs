using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;

namespace Mindstorms.CLI.Commands
{
    internal class Exit : ICliCommand
    {
        public string Name => nameof(Exit);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            Environment.Exit(0);
        }
    }
}
