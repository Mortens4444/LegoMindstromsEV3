using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.System
{
    /// <summary>
    /// Get the name of the brick.
    /// </summary>
    public class GetPin : Command
    {
        public GetPin(CommunicationInterface communicationInterface, string brickName)
        {
            data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
            data.AddRange(new byte[]
            {
                (byte)OpCode.ComGet,
                (byte)ComGetSubCommand.GetPin,
                (byte)communicationInterface
            });
            data.AppendStringParameter(brickName);

            data.Add(Constants.DefaultResponseLength);
            data.Add((byte)ParameterType.Variable | (byte)VariableScope.Global);
        }
    }
}
