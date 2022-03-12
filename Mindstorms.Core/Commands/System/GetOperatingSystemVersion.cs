using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetOperatingSystemVersion : Command
    {
        public GetOperatingSystemVersion()
        {
            data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
            data.AddRange(new byte[]
            {
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetOperatingSystemVersion,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
