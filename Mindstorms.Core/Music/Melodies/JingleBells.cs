using Mindstorms.Core.Music.Notes;

namespace Mindstorms.Core.Music.Melodies;

public class JingleBells : Melody
{
    public JingleBells() : base(new TimeSignature(4, 4), 180,
            new D4(), new B4(), new A4(), new G4(), new D4(NoteType.Half), new D4(NoteType.Eighth), new D4(NoteType.Eighth), new D4(), new B4(), new A4(), new G4(), new E4(NoteType.Half), new Fermata(NoteType.Half),
            new E4(), new C5(), new B4(), new A4(), new Fs4_Gb4(NoteType.Half), new Fermata(NoteType.Half), new D5(), new D5(), new C5(), new A4(), new B4(NoteType.Half), new Fermata(NoteType.Half),
            new D4(), new B4(), new A4(), new G4(), new D4(NoteType.Half), new D4(), new D4(), new B4(), new A4(), new G4(), new E4(NoteType.Half), new E4(),
            new E4(), new C5(), new B4(), new A4(), new D5(), new D5(), new D5(), new D5(), new E5(), new D5(), new C5(), new A4(), new G4(NoteType.Half), new Fermata(NoteType.Half)
        )
    { }

    public override string ToString()
    {
        return "Jingle bells";
    }
}
