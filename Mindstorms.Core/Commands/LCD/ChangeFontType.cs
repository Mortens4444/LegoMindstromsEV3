using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ChangeFontType : LCDCommand
    {
#warning This command must be tested.

        public ChangeFontType(FontType fontType)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.SelectFont,
                (byte)fontType
            };
        }
    }
}
