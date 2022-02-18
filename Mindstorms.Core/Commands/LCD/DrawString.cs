using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.LCD
{
    public class DrawString : LCDCommand
    {
        public DrawString(byte x, byte y, string text, LCDColor color = LCDColor.Black, FontType fontType = FontType.Normal)
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
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                x,
                0,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                y,
                0,
                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(text));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
