using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LED
{
    public class ChangeLedsState : Command
    {
        public ChangeLedsState(LedPattern ledPattern)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.UIWrite);
            data.Add((byte)UIWriteSubCommand.Led);
            data.AppendOneBytesParameter((byte)ledPattern);
        }
    }
}
