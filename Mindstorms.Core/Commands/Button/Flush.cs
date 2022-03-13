using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Button
{
    public class Flush : Command
    {
#warning This command must be tested.

        public Flush()
        {
            data = new List<byte>
            {
                CommandType.DirectCommand | Response.NotExpected,
                1,
                0,

                OpCode.Button,
                ButtonEvent.Flush
            };
        }
    }
}
