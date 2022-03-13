using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetFirmwareBuild : Command
    {
        public GetFirmwareBuild()
        {
            data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
            data.AddRange(new byte[]
            {
                OpCode.UIRead,
                SystemInfoSubCommand.GetFirmwareBuild,
                Constants.DefaultResponseLength,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
