using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.System
{
    public class SetBrickName : Command
    {
        public SetBrickName(string brickName)
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.ComSet);
            data.Add(ComSetSubCommand.SetBrickName);
            data.AppendStringParameter(brickName);
        }
    }
}
