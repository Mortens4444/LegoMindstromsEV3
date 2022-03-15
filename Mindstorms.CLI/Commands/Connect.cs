using Mindstorms.Core.EV3;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.CLI.Commands
{
    internal class Connect : ICliCommand
    {
        public string Name => nameof(Connect);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            brick = new Brick(arguments.First());
            brick.Connect();
        }
    }
}
