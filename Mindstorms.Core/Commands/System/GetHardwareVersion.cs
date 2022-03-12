using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetHardwareVersion : Command
    {
        public GetHardwareVersion()
        {
            data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
            data.AddRange(new byte[]
            {
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetHardwareVersion,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
