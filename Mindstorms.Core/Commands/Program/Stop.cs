using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program
{
    public class Stop : Command
    {
        /// <summary>
        /// Stops all running application.
        /// </summary>
        public Stop()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ProgramStop,
                (byte)ProgramSlot.User
            };
        }
    }
}
