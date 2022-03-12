using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function can be used for stopping a specific object in further execution.
    /// </summary>
    public class Stop : Command
    {
#warning This command must be tested.
        public Stop(ushort objectId)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.ObjectStop);
            data.AppendTwoBytesParameter(objectId);
        }
    }
}
