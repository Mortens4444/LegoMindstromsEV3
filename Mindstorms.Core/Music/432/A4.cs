namespace Mindstorms.Core.Music._432
{
    public class A4 : Note
    {
        public A4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "A4";
            Frequency = 432.00;
            WaveLength = 79.86;
        }
    }
}
