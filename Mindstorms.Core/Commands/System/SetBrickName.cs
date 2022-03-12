using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.System
{
    public class SetBrickName : Command
    {
        public SetBrickName(string brickName)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.ComSet);
            data.Add((byte)ComSetSubCommand.SetBrickName);
            data.AppendStringParameter(brickName);
        }
    }
}
