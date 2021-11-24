using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawCircle : LCDCommand
    {
        public DrawCircle(byte x, byte y, byte radius, Color color, bool fill)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)(fill ? DrawSubCode.FillCircle : DrawSubCode.Circle),
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                (byte)color,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                x,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                y,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                radius
            };
        }
    }
}
