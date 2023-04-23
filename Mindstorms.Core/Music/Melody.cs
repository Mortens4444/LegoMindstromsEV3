namespace Mindstorms.Core.Music;

public abstract class Melody : List<Note>
{
    private readonly byte beatsPerMinunte;

    private readonly double beatDuration;

    private readonly double measureDuration;

    private readonly double wholeNoteLength;
    private double fundamentalFrequency = 440;

    public double FundamentalFrequency
    {
        get => fundamentalFrequency;
        set
        {
            fundamentalFrequency = value;
            foreach (var note in this)
            {
                note.FundamentalFrequency = fundamentalFrequency;
            }
        }
    }

    public string[]? Notes { get; }

    public double MeasureDuration => measureDuration;

    public Melody(TimeSignature timeSignature, byte bpm, params Note[] notes)
    {
        AddRange(notes);

        beatsPerMinunte = bpm;
        beatDuration = 60.0 / beatsPerMinunte;
        measureDuration = beatDuration * timeSignature.NumberOfQuarterNotes;
        wholeNoteLength = beatDuration * timeSignature.Bar;

        Clear();
    }

    public ushort GetNoteLength(NoteType noteType)
    {
        return (ushort)Math.Round(wholeNoteLength * 1000 / Math.Pow(2, (int)noteType));
    }
}
