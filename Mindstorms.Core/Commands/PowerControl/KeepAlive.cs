using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.PowerControl;

public class KeepAlive : Command
{
#warning This command must be tested.
    public KeepAlive(byte minutes)
    {
        data = DirectCommandNoReply;
        data.AddRange(new byte[]
        {
            OpCode.KeepAlive,
            ParameterFormat.Long | FollowType.OneByte,
            minutes
        });
    }
}
