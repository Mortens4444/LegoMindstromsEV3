using Mindstorms.Core.Enums;
using Utils;

namespace Mindstorms.Core.Commands;

public abstract class Command
{
    protected List<byte> data = new();

    public byte[] Data
    {
        get { return data.ToArray(); }
    }

    public bool IsResponseRequired()
    {
        return !Data[0].IsBitSet(0x80);
    }

    protected readonly List<byte> SystemCommandNoReply = new() { CommandType.SystemCommand | Response.NotExpected };

    protected readonly List<byte> SystemCommandWithReply = new() { CommandType.SystemCommand | Response.Required };

    protected readonly List<byte> DirectCommandNoReply = new() { CommandType.DirectCommand | Response.NotExpected, 0, 0 };

    protected readonly byte DirectCommandWithReply = CommandType.DirectCommand | Response.Required;

    protected List<byte> GetDirectCommandWithReply(byte numberOfExpectedBytes, byte localBytes = 0) => new() { DirectCommandWithReply, numberOfExpectedBytes, (byte)(localBytes << 2) };
}
