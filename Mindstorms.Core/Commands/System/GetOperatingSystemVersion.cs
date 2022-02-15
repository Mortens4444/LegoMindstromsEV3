using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetOperatingSystemVersion : Command
    {
        public GetOperatingSystemVersion()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                Constants.DefaultResponseLength,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetOperatingSystemVersion,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
