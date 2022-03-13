namespace Mindstorms.Core.Enums
{
    public class ComGetSubCommand : EnumLikeObject<ComGetSubCommand>
    {
        public static readonly ComGetSubCommand GetOnOff = new ComGetSubCommand(0x01, nameof(GetOnOff));
        public static readonly ComGetSubCommand GetVisible = new ComGetSubCommand(0x02, nameof(GetVisible));
        public static readonly ComGetSubCommand GetResult = new ComGetSubCommand(0x04, nameof(GetResult));
        public static readonly ComGetSubCommand GetPin = new ComGetSubCommand(0x05, nameof(GetPin));
        public static readonly ComGetSubCommand SearchItems = new ComGetSubCommand(0x08, nameof(SearchItems));
        public static readonly ComGetSubCommand SearchItem = new ComGetSubCommand(0x09, nameof(SearchItem));
        public static readonly ComGetSubCommand FavourItems = new ComGetSubCommand(0x0A, nameof(FavourItems));
        public static readonly ComGetSubCommand FavourItem = new ComGetSubCommand(0x0B, nameof(FavourItem));
        public static readonly ComGetSubCommand GetId = new ComGetSubCommand(0x0C, nameof(GetId));
        public static readonly ComGetSubCommand GetBrickName = new ComGetSubCommand(0x0D, nameof(GetBrickName));
        public static readonly ComGetSubCommand GetNetwork = new ComGetSubCommand(0x0E, nameof(GetNetwork));
        public static readonly ComGetSubCommand GetPresent = new ComGetSubCommand(0x0F, nameof(GetPresent));
        public static readonly ComGetSubCommand GetEncrypt = new ComGetSubCommand(0x10, nameof(GetEncrypt));
        public static readonly ComGetSubCommand GetIncomming = new ComGetSubCommand(0x11, nameof(GetIncomming));

        private ComGetSubCommand(byte value, string name) : base(value, name)
        {
            Values.Add(value, this);
        }

        public static implicit operator ComGetSubCommand(byte value)
        {
            return Values[value];
        }

        public static implicit operator byte(ComGetSubCommand value)
        {
            return value.Value;
        }
    }
}
