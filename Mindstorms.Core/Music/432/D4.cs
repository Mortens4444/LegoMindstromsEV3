namespace Mindstorms.Core.Music._432
{
    public class D4 : Note
    {
        public D4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "D4";
            Frequency = 288.33;
            WaveLength = 119.66;
        }
    }
}
