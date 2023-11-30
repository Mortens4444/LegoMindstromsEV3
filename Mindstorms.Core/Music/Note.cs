namespace Mindstorms.Core.Music;

public abstract class Note
{
    /// <summary>
    /// In air on 20°C
    /// </summary>
    private const double SpeedOfSoundMetersPerSecond = 343.2;

    /// <summary>
    /// Name of the note.
    /// </summary>
    public string Name { get; }

    public NoteType NoteType { get; }

    public int SemitoneDeviation { get; }

    /// <summary>
    /// Wave length in meters.
    /// </summary>
    public virtual double WaveLength => SpeedOfSoundMetersPerSecond / Frequency;

    /// <summary>
    /// Frequency in Hertz.
    /// </summary>
    public virtual double Frequency => FundamentalFrequency * Math.Pow(Math.Pow(2, 1 / 12.0), SemitoneDeviation);

    public double FundamentalFrequency { get; set; } = 440;

    public Note(NoteType noteType)
    {
        Name = "Pause";
        NoteType = noteType;
    }

    public Note(NoteType noteType, int semitoneDeviation)
    {
        SemitoneDeviation = semitoneDeviation;
        Name = MusicalScale.NoteNames[semitoneDeviation];
        NoteType = noteType;
    }

    public static implicit operator ushort(Note value)
    {
        return (ushort)Math.Round(value.Frequency);
    }

    public override string ToString()
    {
        return Name;
    }
}
