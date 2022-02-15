using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function should be used in the end of object to indicated the end of the object.
    /// </summary>
    public class End : Command
    {
#warning This command must be tested.
        public End()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ObjectEnd
            };
        }
    }
}
