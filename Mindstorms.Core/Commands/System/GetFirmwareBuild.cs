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
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetFirmwareBuild,
                Constants.DefaultResponseLength,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
