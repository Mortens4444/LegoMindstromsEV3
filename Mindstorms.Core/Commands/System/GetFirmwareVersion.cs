using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetFirmwareVersion : Command
    {
        public GetFirmwareVersion()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                Constants.DefaultResponseLength,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetFirmwareVersion,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
