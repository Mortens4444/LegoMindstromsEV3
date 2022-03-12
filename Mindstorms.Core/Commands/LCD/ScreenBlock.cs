using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ScreenBlock : LCDCommand
    {
        public ScreenBlock(bool set)
        {
            var block = (byte)(set ? 1 : 0);
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.UIWrite);
            data.Add((byte)UIWriteSubCommand.ScreenBlock);
            data.Add(block);
        }
    }
}
