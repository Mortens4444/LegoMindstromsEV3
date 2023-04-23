using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core;

public class CommandReplyBase : ICommandReply
{
    public ushort MessageCounter { get; }

    public CommandType CommandType { get; } = CommandType.DirectCommand;

    public CommandReplyStatus CommandReplyStatus { get; }

    public byte[] RawResponseData { get; }

    public CommandReplyBase(byte[] rawResponseData)
    {
        RawResponseData = rawResponseData;
        if (RawResponseData.Length > 0)
        {
            MessageCounter = BitConverter.ToUInt16(rawResponseData, 0);
            CommandType = rawResponseData[2];

            CommandReplyStatus = rawResponseData.Length > 4 ? (CommandReplyStatus)(rawResponseData[4]) : CommandReplyStatus.NoErrorFlagIsPresent;
        }
    }

    public override string ToString()
    {
        var details = CommandType.HasError() && CommandReplyStatus == CommandReplyStatus.Success ?
            CommandType.ToString() : $"{CommandType} {CommandReplyStatus}";

        return $"#{MessageCounter} {details} Raw data: ({String.Join(", ", RawResponseData)})";
    }

    public string GetResponseAsString()
    {
        return Constants.DefaultEncoding.GetString(RawResponseData, 3, RawResponseData.Length - 3);
    }
}
