using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program;

public class StopCurrent : StopBase
{
    /// <summary>
    /// Stops the currently running application.
    /// </summary>
    public StopCurrent() : base(ProgramSlot.Current)
    { }
}
