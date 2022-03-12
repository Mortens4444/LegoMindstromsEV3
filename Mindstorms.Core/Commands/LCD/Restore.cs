using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD
{
    public class Restore : LCDCommand
    {
#warning This command must be tested.
        public Restore(byte level)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.Restore);
            data.AppendOneBytesParameter(level);
        }
    }
}
