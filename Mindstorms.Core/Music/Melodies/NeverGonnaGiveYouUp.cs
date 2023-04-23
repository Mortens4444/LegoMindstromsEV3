using Mindstorms.Core.Music.Notes;

namespace Mindstorms.Core.Music.Melodies;

public class NeverGonnaGiveYouUp : Melody
{
    public NeverGonnaGiveYouUp() : base(new TimeSignature(4, 4), 120,
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new Fs5_Gb5(), new Fs5_Gb5(), new E5(),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new E5(), new E5(NoteType.Eighth), new Ds5_Eb5(NoteType.Eighth), new Ds5_Eb5(NoteType.Sixteenth), new Cs5_Db5(NoteType.Sixteenth), new B4(NoteType.Eighth),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(), new E5(NoteType.Eighth), new B4(), new A4(), new A4(NoteType.Eighth), new E5(), new D5(NoteType.Half),

            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new Fs5_Gb5(), new Fs5_Gb5(), new E5(),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new E5(), new E5(NoteType.Eighth), new Ds5_Eb5(NoteType.Eighth), new Ds5_Eb5(NoteType.Sixteenth), new Cs5_Db5(NoteType.Sixteenth), new B4(NoteType.Eighth),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(), new E5(NoteType.Eighth), new B4(), new A4(), new A4(NoteType.Eighth), new E5(), new D5(NoteType.Half)
        )
    { }

    public override string ToString()
    {
        return "Never gonna give you up";
    }
}
