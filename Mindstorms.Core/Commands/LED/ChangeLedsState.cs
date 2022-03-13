using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LED
{
    public class ChangeLedsState : Command
    {
        public ChangeLedsState(LedPattern ledPattern)
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.UIWrite);
            data.Add(UIWriteSubCommand.Led);
            data.AppendOneBytesParameter(ledPattern);
        }
    }
}
