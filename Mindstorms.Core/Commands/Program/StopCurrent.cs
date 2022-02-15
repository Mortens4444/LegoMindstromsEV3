using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program
{
    public class StopCurrent : Command
    {
        /// <summary>
        /// Stops the currently running application.
        /// </summary>
        public StopCurrent()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ProgramStop,
                unchecked((byte)ProgramSlot.Current)
            };
        }
    }
}
