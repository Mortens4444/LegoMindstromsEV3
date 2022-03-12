using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD
{
    public class InverseRectangle : LCDCommand
    {
        public InverseRectangle(byte x, byte y, byte width, byte height)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.InverseRectangle);
            data.AppendOneBytesParameter(x);
            data.AppendOneBytesParameter(y);
            data.AppendOneBytesParameter(width);
            data.AppendOneBytesParameter(height);
        }
    }
}
