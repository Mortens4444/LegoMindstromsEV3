using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.PowerControl
{
    public class KeepAlive : Command
    {
#warning This command must be tested.
        public KeepAlive(byte minutes)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.KeepAlive,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                minutes
            };
        }
    }
}
