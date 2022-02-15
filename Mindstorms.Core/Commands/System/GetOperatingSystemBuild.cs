using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetOperatingSystemBuild : Command
    {
        public GetOperatingSystemBuild()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                Constants.DefaultResponseLength,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetOperatingSystemBuild,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
