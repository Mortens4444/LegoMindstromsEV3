using Mindstorms.Core.Music.Notes;

namespace Mindstorms.Core.Music.Melodies;

public class KisKeceLányom : Melody
{
	public KisKeceLányom() : base(new TimeSignature(2, 4), 84,
            new C4(), new G4(NoteType.Eighth), new G4(NoteType.Eighth),
            new G4(), new F4(),
            new G4(), new Ds4_Eb4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth),
            new D4(), new C4(),
            new C4(), new G4(NoteType.Eighth), new G4(NoteType.Eighth),
            new G4(), new F4(),
            new G4(), new Ds4_Eb4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth),
            new D4(), new C4(),
            new C4(NoteType.Eighth), new D4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth),
            new F4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth), new D4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth),
            new D4(), new D4(),
            new D4(), new D4(),
            new C4(NoteType.Eighth), new D4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth),
            new F4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth), new D4(NoteType.Eighth), new Ds4_Eb4(NoteType.Eighth),
            new C4(), new C4(),
            new C4(), new C4()
        )
	{ }

	public override string ToString()
	{
		return "Kis kece lányom";
	}
}