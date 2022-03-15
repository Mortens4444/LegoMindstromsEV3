using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.CLI.Commands
{
    internal class Led : ICliCommand
    {
        public string Name => nameof(Led);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            var ledPattern = LedPattern.Parse(arguments.ElementAt(0));
            brick.ChangeLedsState(ledPattern);
        }
    }
}
