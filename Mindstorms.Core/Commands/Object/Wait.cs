using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function will make the specific execution wait until the specific object have finalized.
    /// </summary>
    public class Wait : Command
    {
#warning This command must be tested.
        public Wait(ushort objectId)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.ObjectWait);
            data.AppendTwoBytesParameter(objectId);
        }
    }
}
