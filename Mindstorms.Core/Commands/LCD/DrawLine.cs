using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawLine : LCDCommand
    {
        public DrawLine(byte x1, byte y1, byte x2, byte y2, LCDColor color)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.Line,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                (byte)color,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                x1,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                y1,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                x2,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                y2
            };
        }
    }
}
