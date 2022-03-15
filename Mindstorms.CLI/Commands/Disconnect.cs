using Mindstorms.Core.EV3;
using System.Collections.Generic;

namespace Mindstorms.CLI.Commands
{
    internal class Disconnect : ICliCommand
    {
        public string Name => nameof(Disconnect);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            brick.Disconnect();
        }
    }
}
