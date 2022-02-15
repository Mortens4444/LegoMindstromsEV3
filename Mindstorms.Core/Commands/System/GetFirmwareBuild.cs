using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetFirmwareBuild : Command
    {
        public GetFirmwareBuild()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                Constants.DefaultResponseLength,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetFirmwareBuild,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
