namespace Mindstorms.Core.Music._432
{
    public class F1 : Note
    {
        public F1(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "F1";
            Frequency = 42.86;
            WaveLength = 804.95;
        }
    }
}
