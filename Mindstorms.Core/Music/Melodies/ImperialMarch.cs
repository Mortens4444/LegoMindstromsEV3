using Mindstorms.Core.Music.Notes;

namespace Mindstorms.Core.Music.Melodies;

public class ImperialMarch : Melody
{
    public ImperialMarch() : base(new TimeSignature(4, 4), 100,
            new A4(), new A4(), new A4(), new F4(NoteType.Eighth), new C5(NoteType.Eighth),
            new A4(), new F4(NoteType.Eighth), new C5(NoteType.Eighth), new A4(NoteType.Half)
        )
    { }

    public override string ToString()
    {
        return "Imperial march";
    }
}
