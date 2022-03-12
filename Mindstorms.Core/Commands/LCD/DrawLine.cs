using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawLine : LCDCommand
    {
        public DrawLine(byte x1, byte y1, byte x2, byte y2, LCDColor color)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.Line);
            data.AppendOneBytesParameter((byte)color);
            data.AppendOneBytesParameter(x1);
            data.AppendOneBytesParameter(y1);
            data.AppendOneBytesParameter(x2);
            data.AppendOneBytesParameter(y2);
        }
    }
}
