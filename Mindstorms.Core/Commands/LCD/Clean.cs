using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class Clean : LCDCommand
    {
        public Clean()
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.DrawUI);
            data.Add(DrawSubCode.Clean);
        }
    }
}
