namespace Mindstorms.Core.Enums;

public class ButtonType : EnumLikeObject<ButtonType>
{
    public static readonly ButtonType None = new(0x00, nameof(None));
    public static readonly ButtonType Up = new(0x01, nameof(Up));
    public static readonly ButtonType Center = new(0x02, nameof(Center));
    public static readonly ButtonType Down = new(0x03, nameof(Down));
    public static readonly ButtonType Right = new(0x04, nameof(Right));
    public static readonly ButtonType Left = new(0x05, nameof(Left));
    public static readonly ButtonType Back = new(0x06, nameof(Back));
    public static readonly ButtonType Any = new(0x07, nameof(Any));

    private ButtonType(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator ButtonType(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(ButtonType value)
    {
        return value.Value;
    }
}
