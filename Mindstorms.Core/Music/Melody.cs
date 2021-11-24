using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Music
{
    public class Melody : List<Note>
    {
        public byte BeatsPerMinunte { get; }

        public double BeatDuration => 60.0 / BeatsPerMinunte;

        public double MeasureDuration => BeatDuration * TimeSignature.NumberOfQuarterNotes;

        public double WholeNoteLength => BeatDuration * TimeSignature.Bar;

        public TimeSignature TimeSignature { get; }

        public string[] Notes { get; }

        public Melody(TimeSignature timeSignature, byte bpm, params Note[] notes)
            : this(timeSignature, bpm)
        {
            AddRange(notes);
        }

        public Melody(TimeSignature timeSignature, byte bpm, params string[] notes)
            : this(timeSignature, bpm)
        {
            Notes = notes;
        }

        private Melody(TimeSignature timeSignature, byte bpm)
        {
            BeatsPerMinunte = bpm;
            TimeSignature = timeSignature;

            Clear();
        }

        public ushort GetNoteLength(NoteType noteType)
        {
            return (ushort)Math.Round(WholeNoteLength * 1000 / Math.Pow(2, (int)noteType));
        }
    }
}
