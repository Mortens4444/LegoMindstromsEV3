using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryTemperatureRise : Command
    {
#warning This command must be tested.
        public GetBatteryTemperatureRise()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                4,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetBatteryTemperatureRise,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
