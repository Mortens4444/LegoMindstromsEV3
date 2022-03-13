namespace Mindstorms.Core.Enums
{
    public class ProgramMode : EnumLikeObject<ProgramMode>
    {
        public static readonly ProgramMode Normal = new ProgramMode(0x00, nameof(Normal));
        public static readonly ProgramMode Debug = new ProgramMode(0x01, nameof(Debug));
        public static readonly ProgramMode DoNotExecute = new ProgramMode(0x02, nameof(DoNotExecute));

        private ProgramMode(byte value, string name) : base(value, name)
        {
            Values.Add(value, this);
        }

        public static implicit operator ProgramMode(byte value)
        {
            return Values[value];
        }

        public static implicit operator byte(ProgramMode value)
        {
            return value.Value;
        }
    }
}
