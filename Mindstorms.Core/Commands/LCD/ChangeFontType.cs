using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ChangeFontType : LCDCommand
    {
#warning This command must be tested.

        public ChangeFontType(FontType fontType)
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.DrawUI);
            data.Add(DrawSubCode.SelectFont);
            data.Add(fontType);
        }
    }
}
