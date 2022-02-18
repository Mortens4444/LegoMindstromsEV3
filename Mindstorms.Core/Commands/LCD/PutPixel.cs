using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class PutPixel : LCDCommand
    {
        public PutPixel(byte x, byte y, LCDColor color)
        {
            ValidatePixel(x, y);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.Pixel,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                (byte)color,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                x,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                y
            };
        }
    }
}
