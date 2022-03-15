using Mindstorms.Core.EV3;
using System.Collections.Generic;

namespace Mindstorms.CLI.Commands
{
    internal interface ICliCommand
    {
        string Name { get; }

        void Action(ref Brick brick, IEnumerable<string> arguments);
    }
}
