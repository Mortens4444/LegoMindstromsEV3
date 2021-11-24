using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ChangeLedsState : Command
    {
        public ChangeLedsState(LedPattern ledPattern)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.UIWrite,
                (byte)UIWriteSubCommand.Led,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                (byte)ledPattern
            };
        }
    }
}
