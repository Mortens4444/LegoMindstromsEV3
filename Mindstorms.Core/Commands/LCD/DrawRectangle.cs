using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawRectangle : LCDCommand
    {
        public DrawRectangle(byte x, byte y, byte width, byte height, LCDColor color, bool fill)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)(fill ? DrawSubCode.FillRectangle : DrawSubCode.Rectangle));
            data.AppendOneBytesParameter((byte)color);
            data.AppendTwoBytesParameter(x);
            data.AppendTwoBytesParameter(y);
            data.AppendTwoBytesParameter(width);
            data.AppendTwoBytesParameter(height);
        }
    }
}
