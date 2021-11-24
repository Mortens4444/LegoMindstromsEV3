namespace Mindstorms.Core.Music
{
    public class Fermata : Note
    {
        public Fermata(NoteType noteType = NoteType.Quarter) : base(noteType)
        {
            Name = "Pause";
            Frequency = 0;
            WaveLength = 0;
        }
    }
}
