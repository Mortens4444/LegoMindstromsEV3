using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.PowerControl
{
    public class KeepAlive : Command
    {
#warning This command must be tested.
        public KeepAlive(byte minutes)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                (byte)OpCode.KeepAlive,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                minutes
            });
        }
    }
}
