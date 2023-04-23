using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System;

/// <summary>
/// Get if a communication device is active or not.
/// </summary>
public class IsActive : Command
{
#warning This command must be tested.
    public IsActive(CommunicationInterface communicationInterface)
    {
        data = GetDirectCommandWithReply(64);
        data.AddRange(new byte[]
        {
            OpCode.ComGet,
            ComGetSubCommand.GetOnOff,
            communicationInterface,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
