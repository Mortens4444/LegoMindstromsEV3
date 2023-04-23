using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD;

public class DrawString : LCDCommand
{
    public DrawString(byte x, byte y, string text, LCDColor color, FontType fontType)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.SelectFont);
        data.Add(fontType);
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Text);
        data.AppendOneBytesParameter(color);
        data.AppendTwoBytesParameter(x);
        data.AppendTwoBytesParameter(y);
        data.AppendStringParameter(text);
    }
}
