namespace Mindstorms.Core.Music._432
{
    public class D5 : Note
    {
        public D5(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "D5";
            Frequency = 576.65;
            WaveLength = 59.83;
        }
    }
}
