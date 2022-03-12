using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawString : LCDCommand
    {
        public DrawString(byte x, byte y, string text, LCDColor color = LCDColor.Black, FontType fontType = FontType.Normal)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.SelectFont);
            data.Add((byte)fontType);
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.Text);
            data.AppendOneBytesParameter((byte)color);
            data.AppendTwoBytesParameter(x);
            data.AppendTwoBytesParameter(y);
            data.AppendStringParameter(text);
        }
    }
}
