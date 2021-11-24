using Mindstorms.Core.Music._440;

namespace Mindstorms.Core.Music.Melodies
{
    public class BociBoci : Melody
    {
        public BociBoci() : base(new TimeSignature(2, 4), 100,
            new C4(NoteType.Eighth), new E4(NoteType.Eighth), new C4(NoteType.Eighth), new E4(NoteType.Eighth), new G4(), new G4(),
            new C4(NoteType.Eighth), new E4(NoteType.Eighth), new C4(NoteType.Eighth), new E4(NoteType.Eighth), new G4(), new G4(),
            new C5(NoteType.Eighth), new B4(NoteType.Eighth), new A4(NoteType.Eighth), new G4(NoteType.Eighth), new F4(), new A4(),
            new G4(NoteType.Eighth), new F4(NoteType.Eighth), new E4(NoteType.Eighth), new D4(NoteType.Eighth), new C4(), new C4())
        { }

        public override string ToString()
        {
            return "Boci, boci";
        }
    }
}
