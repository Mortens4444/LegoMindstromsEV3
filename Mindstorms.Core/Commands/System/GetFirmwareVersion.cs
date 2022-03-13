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
                OpCode.UIRead,
                SystemInfoSubCommand.GetFirmwareVersion,
                Constants.DefaultResponseLength,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
