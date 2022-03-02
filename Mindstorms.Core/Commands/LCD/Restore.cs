using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class Restore : LCDCommand
    {
#warning This command must be tested.
        public Restore(byte level)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.Restore,
                
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                level
            };
        }
    }
}
