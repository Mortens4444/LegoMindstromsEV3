namespace Mindstorms.Core.Music._440
{
    public class A4 : Note
    {
        public A4(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "A4";
            Frequency = 440.00;
            WaveLength = 78.41;
        }
    }
}
