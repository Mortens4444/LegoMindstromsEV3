using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD
{
    public class PutPixel : LCDCommand
    {
        public PutPixel(byte x, byte y, LCDColor color)
        {
            ValidatePixel(x, y);

            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.Pixel);
            data.AppendOneBytesParameter((byte)color);
            data.AppendOneBytesParameter(x);
            data.AppendOneBytesParameter(y);
        }
    }
}
