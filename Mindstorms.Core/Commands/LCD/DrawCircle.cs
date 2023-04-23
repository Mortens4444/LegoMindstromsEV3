using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD;

public class DrawCircle : LCDCommand
{
    public DrawCircle(byte x, byte y, byte radius, LCDColor color, bool fill)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(fill ? DrawSubCode.FillCircle : DrawSubCode.Circle);
        data.AppendOneBytesParameter(color);
        data.AppendTwoBytesParameter(x);
        data.AppendTwoBytesParameter(y);
        data.AppendTwoBytesParameter(radius);
    }
}
