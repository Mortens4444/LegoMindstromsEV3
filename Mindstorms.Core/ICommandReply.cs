using Mindstorms.Core.Enums;

namespace Mindstorms.Core
{
    public interface ICommandReply
    {
        ushort MessageCounter { get; }

        CommandType CommandType { get; }

        CommandReplyStatus CommandReplyStatus { get; }

        byte[] RawResponseData { get; }
    }
}
