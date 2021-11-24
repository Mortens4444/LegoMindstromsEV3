using Mindstorms.Core.Music._440;

namespace Mindstorms.Core.Music.Melodies
{
    public class NeverGonnaGiveYouUp : Melody
    {
        public NeverGonnaGiveYouUp() : base(new TimeSignature(4, 4), 120,
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new Fisz5(), new Fisz5(), new E5(),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new E5(), new E5(NoteType.Eighth), new Disz5(NoteType.Eighth), new Disz5(NoteType.Sixteenth), new Cisz5(NoteType.Sixteenth), new B4(NoteType.Eighth),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(), new E5(NoteType.Eighth), new B4(), new A4(), new A4(NoteType.Eighth), new E5(), new D5(NoteType.Half),

            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new Fisz5(), new Fisz5(), new E5(),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new E5(), new E5(NoteType.Eighth), new Disz5(NoteType.Eighth), new Disz5(NoteType.Sixteenth), new Cisz5(NoteType.Sixteenth), new B4(NoteType.Eighth),
            new A4(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(NoteType.Sixteenth), new B4(NoteType.Sixteenth), new D5(), new E5(NoteType.Eighth), new B4(), new A4(), new A4(NoteType.Eighth), new E5(), new D5(NoteType.Half))
        { }

        public override string ToString()
        {
            return "Never gonna give you up";
        }
    }
}
