namespace Mindstorms.Core.Music._432
{
    public class F0 : Note
    {
        public F0(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "F0";
            Frequency = 21.43;
            WaveLength = 1609.90;
        }
    }
}
