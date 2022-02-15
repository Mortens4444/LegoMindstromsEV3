using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class ScreenBlock : LCDCommand
    {
        public ScreenBlock(bool set)
        {
            var block = set ? (byte)1 : (byte)0;
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.UIWrite,
                (byte)UIWriteSubCommand.ScreenBlock,
                block
            };
        }
    }
}
