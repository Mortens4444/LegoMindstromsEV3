using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class Update : LCDCommand
    {
        public Update()
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.DrawUI);
            data.Add(DrawSubCode.Update);
        }
    }
}
