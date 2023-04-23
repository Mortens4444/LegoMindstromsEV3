using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.System;

/// <summary>
/// Get the pin code of the brick.
/// </summary>
public class GetPin : Command
{
    public GetPin(CommunicationInterface communicationInterface, string brickName)
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(new byte[]
        {
            OpCode.ComGet,
            ComGetSubCommand.GetPin,
            communicationInterface
        });
        data.AppendStringParameter(brickName);

        data.Add(Constants.DefaultResponseLength);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
