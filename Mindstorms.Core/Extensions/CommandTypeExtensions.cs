using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Extensions;

public static class CommandTypeExtensions
{
    public static bool HasError(this CommandType commandType)
    {
        return commandType == CommandType.SystemCommandReplyWithError || commandType == CommandType.DirectCommandReplyWithError;
    }
}
