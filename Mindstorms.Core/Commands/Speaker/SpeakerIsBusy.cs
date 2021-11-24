using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Speaker
{
    public class SpeakerIsBusy : Command
    {
        public SpeakerIsBusy()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                1,
                0,
                (byte)OpCode.SoundTest,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
