namespace Mindstorms.Core.Music;

public class Fermata : Note
{
    public Fermata(NoteType noteType = NoteType.Quarter) : base(noteType)
    {
    }

    public override double Frequency => 0;

    public override double WaveLength => 0;
}
