using Mindstorms.Core.Enums;
using System.Collections.Generic;
using System.Text;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawString : LCDCommand
    {
        public DrawString(byte x, byte y, string text, Color color = Color.Black, FontType fontType = FontType.Small)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.SelectFont,
                (byte)fontType,
                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.Text,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                (byte)color,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                x,
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                y,
                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            dataList.AddRange(Encoding.ASCII.GetBytes(text));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
