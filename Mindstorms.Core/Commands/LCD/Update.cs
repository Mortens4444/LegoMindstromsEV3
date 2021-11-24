using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class Update : LCDCommand
    {
        public Update()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.Update
            };
        }
    }
}
