using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.System;

public class SetVolume : Command
{
    public SetVolume(byte volume)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.Info);
        data.Add(InfoSubCode.SetVolume);
        data.AppendOneBytesParameter(volume);
    }
}
