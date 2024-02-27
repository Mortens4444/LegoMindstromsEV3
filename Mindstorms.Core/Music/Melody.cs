namespace Mindstorms.Core.Music;

public abstract class Melody : List<Note>
{
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

    protected Melody(TimeSignature timeSignature, byte beatsPerMinute, params Note[] notes)
    {
        AddRange(notes);

        var beatDuration = 60.0 / beatsPerMinute;
        measureDuration = beatDuration * timeSignature.NumberOfQuarterNotes;
        wholeNoteLength = beatDuration * timeSignature.Bar;
    }

    public ushort GetNoteLength(NoteType noteType)
    {
        return (ushort)Math.Round(wholeNoteLength * 1000 / Math.Pow(2, (int)noteType));
    }
}
