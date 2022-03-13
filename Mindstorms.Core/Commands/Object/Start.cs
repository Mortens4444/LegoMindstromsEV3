using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function can be used for starting a specific object to execute.
    /// </summary>
    public class Start : Command
    {
#warning This command must be tested.
        public Start(ushort objectId)
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.ObjectStart);
            data.AppendTwoBytesParameter(objectId);
        }
    }
}
