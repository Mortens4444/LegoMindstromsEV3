using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button
{
    public class ReleaseButton : Command
    {
#warning This command must be tested.

        public ReleaseButton(ButtonType button)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Release,
                (byte)button
            };
        }
    }
}
