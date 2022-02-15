using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryVoltage : Command
    {
        public GetBatteryVoltage()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                4,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetBatteryVoltage,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
