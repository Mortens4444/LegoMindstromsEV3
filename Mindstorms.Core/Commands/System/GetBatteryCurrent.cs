using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryCurrent : Command
    {
        public GetBatteryCurrent()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                4,
                0,

                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetBatteryCurrent,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
