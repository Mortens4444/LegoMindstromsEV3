using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button
{
    public class Flush : Command
    {
#warning This command must be tested.

        public Flush()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                1,
                0,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Flush
            };
        }
    }
}
