using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.CLI.Commands
{
    internal class Beep : ICliCommand
    {
        public string Name => nameof(Beep);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            var volume = Convert.ToByte(arguments.ElementAt(0));
            var frequency = Convert.ToUInt16(arguments.ElementAt(1));
            var durationMs = Convert.ToUInt16(arguments.ElementAt(2));
            brick.Beep(volume, frequency, durationMs);
        }
    }
}
