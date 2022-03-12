using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetFirmwareVersion : Command
    {
        public GetFirmwareVersion()
        {
            data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
            data.AddRange(new byte[]
            {
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetFirmwareVersion,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
