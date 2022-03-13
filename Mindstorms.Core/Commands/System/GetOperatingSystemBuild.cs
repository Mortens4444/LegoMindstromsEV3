using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetOperatingSystemBuild : Command
    {
        public GetOperatingSystemBuild()
        {
            data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
            data.AddRange(new byte[]
            {
                OpCode.UIRead,
                SystemInfoSubCommand.GetOperatingSystemBuild,
                Constants.DefaultResponseLength,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
