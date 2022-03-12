using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ChangeTopLine : LCDCommand
    {
        public ChangeTopLine(State state)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.TopLine);
            data.Add((byte)state);
        }
    }
}
