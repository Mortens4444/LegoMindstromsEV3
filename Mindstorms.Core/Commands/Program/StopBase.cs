using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program
{
    public abstract class StopBase : Command
    {
        public StopBase(ProgramSlot programslot)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.ProgramStop);
            data.Add(unchecked((byte)programslot));
        }
    }
}
