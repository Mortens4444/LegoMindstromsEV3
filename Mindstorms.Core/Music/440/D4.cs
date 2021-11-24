namespace Mindstorms.Core.Music._440
{
    public class D4 : Note
    {
        public D4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "D4";
            Frequency = 293.66;
            WaveLength = 117.48;
        }
    }
}
