using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawRectangle : LCDCommand
    {
        public DrawRectangle(byte x, byte y, byte width, byte height, Color color, bool fill)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)(fill ? DrawSubCode.FillRectangle : DrawSubCode.Rectangle),
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                (byte)color,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                x,
                0,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                y,
                0,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                width,
                0,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                height,
                0
            };
        }
    }
}
