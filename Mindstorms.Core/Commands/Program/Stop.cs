using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program;

public class Stop : StopBase
{
    /// <summary>
    /// Stops all running application.
    /// </summary>
    public Stop() : base(ProgramSlot.User)
    { }
}
