﻿namespace Mindstorms.Core.Music;

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
    public virtual double Frequency => FundamentalFrequency * Math.Pow(2, SemitoneDeviation / 12.0);

    public double FundamentalFrequency { get; set; } = 440;

    protected Note(NoteType noteType)
    {
        Name = "Pause";
        NoteType = noteType;
    }

    protected Note(NoteType noteType, int semitoneDeviation)
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
