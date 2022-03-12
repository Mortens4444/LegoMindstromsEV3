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
                (byte)OpCode.ComGet,
                (byte)ComGetSubCommand.GetBrickName,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
