using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Extensions
{
    public static class CommandTypeExtensions
    {
        public static bool IsError(this CommandType commandType)
        {
            return commandType == CommandType.SystemCommandReplyWithError || commandType == CommandType.DirectCommandReplyWithError;
        }
    }
}
