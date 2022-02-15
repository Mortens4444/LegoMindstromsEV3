using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetHardwareVersion : Command
    {
        public GetHardwareVersion()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                Constants.DefaultResponseLength,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetHardwareVersion,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
