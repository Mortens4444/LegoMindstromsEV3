using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Object;

/// <summary>
/// This function trigger the specific object and initaite execution if alle trigger requirements are active.
/// </summary>
public class Trigger : Command
{
#warning This command must be tested.
    public Trigger(ushort objectId)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.ObjectTrigger);
        data.AppendTwoBytesParameter(objectId);
    }
}
