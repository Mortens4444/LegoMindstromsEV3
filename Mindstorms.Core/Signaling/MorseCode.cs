using System.Collections.Generic;

namespace Mindstorms.Core.Signaling
{
    public class MorseCode
    {
        public char Character { get; set; }

        public List<Signal> Signals { get; set; }

        public MorseCode(char character, List<Signal> signals)
        {
            Character = character;
            Signals = signals;
        }
    }
}
