namespace Mindstorms.Core.Music._440
{
    public class C4 : Note
    {
        public C4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "C4";
            Frequency = 261.63;
            WaveLength = 131.87;
        }
    }
}
