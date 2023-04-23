using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD;

public class ChangeTopLine : LCDCommand
{
    public ChangeTopLine(State state)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.TopLine);
        data.Add(state);
    }
}
