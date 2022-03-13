using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ScreenBlock : LCDCommand
    {
        public ScreenBlock(bool set)
        {
            var block = (byte)(set ? 1 : 0);
            data = DirectCommandNoReply;
            data.Add(OpCode.UIWrite);
            data.Add(UIWriteSubCommand.ScreenBlock);
            data.Add(block);
        }
    }
}
