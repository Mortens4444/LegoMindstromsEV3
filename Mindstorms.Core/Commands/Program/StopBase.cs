using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program
{
    public abstract class StopBase : Command
    {
        public StopBase(ProgramSlot programslot)
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.ProgramStop);
            data.Add(programslot);
        }
    }
}
