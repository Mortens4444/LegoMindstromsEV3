namespace Mindstorms.Core.Music
{
    public class TimeSignature
    {
        public byte NumberOfQuarterNotes { get; set; }

        public byte Bar { get; set; }

        public TimeSignature(byte numberOfQuarterNotes, byte bar)
        {
            NumberOfQuarterNotes = numberOfQuarterNotes;
            Bar = bar;
        }
    }
}
