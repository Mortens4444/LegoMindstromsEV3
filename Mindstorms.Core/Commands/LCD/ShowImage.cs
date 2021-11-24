using Mindstorms.Core.Enums;
using System.Collections.Generic;
using System.Text;

namespace Mindstorms.Core.Commands.LCD
{
    public class ShowImage : LCDCommand
    {
        public ShowImage(byte x, byte y, string filePath, Color color)
        {
            ValidatePixel(x, y);

            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                0x13, // FillWindow
                color == Color.White ? (byte)Color.Black : (byte)Color.White, // BackgroundColor
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                0x00, // Start y
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                0x00, // End y
                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.BmpFile,
                (byte)color, // ForegroundColor
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                x,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                y,
                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            dataList.AddRange(Encoding.ASCII.GetBytes(filePath));
            dataList.AddRange(new byte[] {
                0,
                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.Update
            });

            data = dataList.ToArray();
        }
    }
}
