namespace Mindstorms.Core.Music._440
{
    public class F4 : Note
    {
        public F4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "F4";
            Frequency = 349.23;
            WaveLength = 98.79;
        }
    }
}
