using Mindstorms.Core.Enums;

namespace Mindstorms.Core
{
    public interface ICommandReply
    {
        ushort MessageCounter { get; }

        CommandType TypeOfMessage { get; }

        CommandReplyStatus CommandReplyStatus { get; }

        byte[] RawResponseData { get; }
    }
}
