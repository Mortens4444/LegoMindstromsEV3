namespace Mindstorms.Core.Music._444
{
    public class A4 : Note
    {
        public A4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "A4";
            Frequency = 444.00;
            WaveLength = 77.70;
        }
    }
}
