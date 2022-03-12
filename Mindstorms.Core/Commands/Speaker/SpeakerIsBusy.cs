using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Speaker
{
    public class SpeakerIsBusy : Command
    {
        public SpeakerIsBusy()
        {
            data = GetDirectCommandWithReply(1);
            data.Add((byte)OpCode.SoundTest);
            data.Add((byte)ParameterType.Variable | (byte)VariableScope.Global);
        }
    }
}
