using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button
{
    public class PressButton : Command
    {
#warning This command must be tested.

        public PressButton(ButtonType button)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Press,
                (byte)button,

                (byte)OpCode.Button,
                (byte)ButtonEvent.WaitForPress
            };
        }
    }
}
