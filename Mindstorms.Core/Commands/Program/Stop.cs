using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class StopCommand : Command
    {
        /// <summary>
        /// Stops all running application.
        /// </summary>
        public StopCommand()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                0,
                0,

                (byte)OpCode.ProgramStop,
                (byte)ProgramSlot.User
            };
        }
    }
}
