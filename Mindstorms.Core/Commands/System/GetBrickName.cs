using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    /// <summary>
    /// Get the name of the brick.
    /// </summary>
    public class GetBrickName : Command
    {
        public GetBrickName()
        {
            data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
            data.AddRange(new byte[]
            {
                OpCode.ComGet,
                ComGetSubCommand.GetBrickName,
                Constants.DefaultResponseLength,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
