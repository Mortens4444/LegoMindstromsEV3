using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class Update : LCDCommand
    {
        public Update()
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.Update);
        }
    }
}
