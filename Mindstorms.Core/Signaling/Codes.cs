using System.Collections.Generic;

namespace Mindstorms.Core.Signaling
{
    public static class Codes
    {
        public static readonly List<MorseCode> MorseCodes = new List<MorseCode>
        {
            new MorseCode('A', new List<Signal>{ Signal.Di, Signal.Dah }),
            new MorseCode('B', new List<Signal>{ Signal.Dah, Signal.Di, Signal.Di, Signal.Di }),
            new MorseCode('C', new List<Signal>{ Signal.Dah, Signal.Di, Signal.Dah, Signal.Di }),
            new MorseCode('D', new List<Signal>{ Signal.Dah, Signal.Di, Signal.Di }),
            new MorseCode('E', new List<Signal>{ Signal.Di }),
            new MorseCode('F', new List<Signal>{ Signal.Di, Signal.Di, Signal.Dah, Signal.Di }),
            new MorseCode('G', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Di }),
            new MorseCode('H', new List<Signal>{ Signal.Di, Signal.Di, Signal.Di, Signal.Di }),
            new MorseCode('I', new List<Signal>{ Signal.Di, Signal.Di }),
            new MorseCode('J', new List<Signal>{ Signal.Di, Signal.Dah, Signal.Dah, Signal.Dah }),
            new MorseCode('K', new List<Signal>{ Signal.Dah, Signal.Di, Signal.Dah }),
            new MorseCode('L', new List<Signal>{ Signal.Di, Signal.Dah, Signal.Di, Signal.Di }),
            new MorseCode('M', new List<Signal>{ Signal.Dah, Signal.Dah }),
            new MorseCode('N', new List<Signal>{ Signal.Dah, Signal.Di }),
            new MorseCode('O', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Dah }),
            new MorseCode('P', new List<Signal>{ Signal.Di, Signal.Dah, Signal.Dah, Signal.Di }),
            new MorseCode('Q', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Di, Signal.Dah }),
            new MorseCode('R', new List<Signal>{ Signal.Di, Signal.Dah, Signal.Di }),
            new MorseCode('S', new List<Signal>{ Signal.Di, Signal.Di, Signal.Di }),
            new MorseCode('T', new List<Signal>{ Signal.Dah }),
            new MorseCode('U', new List<Signal>{ Signal.Di, Signal.Di, Signal.Dah }),
            new MorseCode('V', new List<Signal>{ Signal.Di, Signal.Di, Signal.Di, Signal.Dah }),
            new MorseCode('W', new List<Signal>{ Signal.Di, Signal.Dah, Signal.Dah }),
            new MorseCode('X', new List<Signal>{ Signal.Dah, Signal.Di, Signal.Di, Signal.Dah }),
            new MorseCode('Y', new List<Signal>{ Signal.Dah, Signal.Di, Signal.Dah, Signal.Dah }),
            new MorseCode('Z', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Di, Signal.Di }),
            new MorseCode('0', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah }),
            new MorseCode('1', new List<Signal>{ Signal.Di, Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah }),
            new MorseCode('2', new List<Signal>{ Signal.Di, Signal.Di, Signal.Dah, Signal.Dah, Signal.Dah }),
            new MorseCode('3', new List<Signal>{ Signal.Di, Signal.Di, Signal.Di, Signal.Dah, Signal.Dah }),
            new MorseCode('4', new List<Signal>{ Signal.Di, Signal.Di, Signal.Di, Signal.Di, Signal.Dah }),
            new MorseCode('5', new List<Signal>{ Signal.Di, Signal.Di, Signal.Di, Signal.Di, Signal.Di }),
            new MorseCode('6', new List<Signal>{ Signal.Dah, Signal.Di, Signal.Di, Signal.Di, Signal.Di }),
            new MorseCode('7', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Di, Signal.Di, Signal.Di }),
            new MorseCode('8', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Dah, Signal.Di, Signal.Di }),
            new MorseCode('9', new List<Signal>{ Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah, Signal.Di }),
            new MorseCode('?', new List<Signal>{ Signal.Di, Signal.Di, Signal.Dah, Signal.Dah, Signal.Di, Signal.Di })
        };
    }
}
