namespace Mindstorms.Core.Music._440
{
    public class F0 : Note
    {
        public F0(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "F0";
            Frequency = 21.83;
            WaveLength = 1580.63;
        }
    }
}
