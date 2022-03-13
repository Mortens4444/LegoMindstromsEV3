namespace Mindstorms.Core.Enums
{
    public class ComSetSubCommand : EnumLikeObject<ComSetSubCommand>
    {
        public static readonly ComSetSubCommand SetOnOff = new ComSetSubCommand(0x01, nameof(SetOnOff));
        public static readonly ComSetSubCommand SetVisible = new ComSetSubCommand(0x02, nameof(SetVisible));
        public static readonly ComSetSubCommand SetSearch = new ComSetSubCommand(0x03, nameof(SetSearch));
        public static readonly ComSetSubCommand SetPin = new ComSetSubCommand(0x05, nameof(SetPin));
        public static readonly ComSetSubCommand SetPasskey = new ComSetSubCommand(0x06, nameof(SetPasskey));
        public static readonly ComSetSubCommand SetConnection = new ComSetSubCommand(0x07, nameof(SetConnection));
        public static readonly ComSetSubCommand SetBrickName = new ComSetSubCommand(0x08, nameof(SetBrickName));
        public static readonly ComSetSubCommand SetMoveUp = new ComSetSubCommand(0x09, nameof(SetMoveUp));
        public static readonly ComSetSubCommand SetMoveDown = new ComSetSubCommand(0x0A, nameof(SetMoveDown));
        public static readonly ComSetSubCommand SetEncrypt = new ComSetSubCommand(0x0B, nameof(SetEncrypt));
        public static readonly ComSetSubCommand SetSSID = new ComSetSubCommand(0x0C, nameof(SetSSID));

        private ComSetSubCommand(byte value, string name) : base(value, name)
        {
            Values.Add(value, this);
        }

        public static implicit operator ComSetSubCommand(byte value)
        {
            return Values[value];
        }

        public static implicit operator byte(ComSetSubCommand value)
        {
            return value.Value;
        }
    }
}
