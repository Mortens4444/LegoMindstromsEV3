using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Speaker;

public class SpeakerIsBusy : Command
{
    public SpeakerIsBusy()
    {
        data = GetDirectCommandWithReply(1);
        data.Add(OpCode.SoundTest);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
