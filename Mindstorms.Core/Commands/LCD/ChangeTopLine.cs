using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ChangeTopLine : LCDCommand
    {
        public ChangeTopLine(State state)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.TopLine,
                (byte)state
            };
        }
    }
}
