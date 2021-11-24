namespace Mindstorms.Core.Music._432
{
    public class C4 : Note
    {
        public C4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "C4";
            Frequency = 256.87;
            WaveLength = 134.31;
        }
    }
}
