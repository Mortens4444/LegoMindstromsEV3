namespace Mindstorms.Core.Music._444
{
    public class G1 : Note
    {
        public G1(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "G1";
            Frequency = 49.44;
            WaveLength = 697.75;
        }
    }
}
