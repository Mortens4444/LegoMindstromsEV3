using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program
{
    public abstract class StopBase : Command
    {
        public StopBase(ProgramSlot programslot)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ProgramStop,
                unchecked((byte)programslot)
            };
        }
    }
}
