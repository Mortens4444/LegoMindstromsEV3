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
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetOperatingSystemBuild,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
