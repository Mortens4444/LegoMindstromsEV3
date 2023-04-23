using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD;

public class Restore : LCDCommand
{
#warning This command must be tested.
    public Restore(byte level)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Restore);
        data.AppendOneBytesParameter(level);
    }
}
