using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryLevel : Command
    {
        public GetBatteryLevel()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                1,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetBatteryLevel,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
