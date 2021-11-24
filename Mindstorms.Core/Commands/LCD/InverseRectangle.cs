using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class InverseRectangle : LCDCommand
    {
        public InverseRectangle(byte x, byte y, byte width, byte height)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.InverseRectangle,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                x,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                y,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                width,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                height
            };
        }
    }
}
