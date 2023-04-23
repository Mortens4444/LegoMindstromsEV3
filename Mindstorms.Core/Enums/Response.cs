namespace Mindstorms.Core.Enums;

public class Response : EnumLikeObject<Response>
{
    public static readonly Response Required = new(0x00, nameof(Required));
    public static readonly Response NotExpected = new(0x80, nameof(NotExpected));

    private Response(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator Response(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(Response value)
    {
        return value.Value;
    }
}
