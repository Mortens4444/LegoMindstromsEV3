using System;

namespace Mindstorms.Core.Music
{
    public abstract class Note
    {
        /// <summary>
        /// Name of the note.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Frequency in Hertz.
        /// </summary>
        public double Frequency { get; protected set; }

        /// <summary>
        /// Wave length in centimeters.
        /// </summary>
        public double WaveLength { get; protected set; }

        public NoteType NoteType { get; }

        public Note(NoteType noteType)
        {
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
}
