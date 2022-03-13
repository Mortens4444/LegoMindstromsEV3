namespace Mindstorms.Core.Enums
{
    public class ButtonEvent : EnumLikeObject<ButtonEvent>
    {
        public static readonly ButtonEvent ShortPress = new ButtonEvent(0x01, nameof(ShortPress));
        public static readonly ButtonEvent LongPress = new ButtonEvent(0x02, nameof(LongPress));
        public static readonly ButtonEvent WaitForPress = new ButtonEvent(0x03, nameof(WaitForPress));
        public static readonly ButtonEvent Flush = new ButtonEvent(0x04, nameof(Flush));
        public static readonly ButtonEvent Press = new ButtonEvent(0x05, nameof(Press));
        public static readonly ButtonEvent Release = new ButtonEvent(0x06, nameof(Release));
        public static readonly ButtonEvent GetHoizontalArrowsState = new ButtonEvent(0x07, nameof(GetHoizontalArrowsState));
        public static readonly ButtonEvent GetVerticalArrowsState = new ButtonEvent(0x08, nameof(GetVerticalArrowsState));
        public static readonly ButtonEvent Pressed = new ButtonEvent(0x09, nameof(Pressed));
        public static readonly ButtonEvent SetBackButtonBlock = new ButtonEvent(0x0A, nameof(SetBackButtonBlock));
        public static readonly ButtonEvent GetBackButtonBlock = new ButtonEvent(0x0B, nameof(GetBackButtonBlock));
        public static readonly ButtonEvent TestShortPress = new ButtonEvent(0x0C, nameof(TestShortPress));
        public static readonly ButtonEvent TestLongPress = new ButtonEvent(0x0D, nameof(TestLongPress));
        public static readonly ButtonEvent GetBumped = new ButtonEvent(0x0E, nameof(GetBumped));
        public static readonly ButtonEvent GetClick = new ButtonEvent(0x0F, nameof(GetClick));

        private ButtonEvent(byte value, string name) : base(value, name)
        {
            Values.Add(value, this);
        }

        public static implicit operator ButtonEvent(byte value)
        {
            return Values[value];
        }

        public static implicit operator byte(ButtonEvent value)
        {
            return value.Value;
        }
    }
}
