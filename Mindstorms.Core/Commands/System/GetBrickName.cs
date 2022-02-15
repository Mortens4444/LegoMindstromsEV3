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
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                Constants.DefaultResponseLength,
                0,

                (byte)OpCode.ComGet,
                (byte)ComGetSubCommand.GetBrickName,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
