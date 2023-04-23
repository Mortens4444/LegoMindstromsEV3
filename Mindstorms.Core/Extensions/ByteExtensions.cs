using Mindstorms.Core.Enums;
using Utils;

namespace Mindstorms.Core.Extensions;

public static class ByteExtensions
{
    public static bool IsSystemCommand(this byte value)
    {
        return value.IsBitSet(CommandType.SystemCommand);
    }
}
