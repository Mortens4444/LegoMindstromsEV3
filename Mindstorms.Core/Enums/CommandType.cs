namespace Mindstorms.Core.Enums;

public class CommandType : EnumLikeObject<CommandType>
{
    public static readonly CommandType DirectCommand = new(0x00, nameof(DirectCommand));
    public static readonly CommandType SystemCommand = new(0x01, nameof(SystemCommand));
    public static readonly CommandType DirectCommandReply = new(0x02, nameof(DirectCommandReply));
    public static readonly CommandType SystemCommandReply = new(0x03, nameof(SystemCommandReply));
    public static readonly CommandType DirectCommandReplyWithError = new(0x04, nameof(DirectCommandReplyWithError));
    public static readonly CommandType SystemCommandReplyWithError = new(0x05, nameof(SystemCommandReplyWithError));

    private CommandType(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator CommandType(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(CommandType value)
    {
        return value.Value;
    }

    public static byte operator |(CommandType commandType, Response response) => (byte)(commandType.Value | response.Value);
}
