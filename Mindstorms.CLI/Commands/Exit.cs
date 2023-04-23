using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class Exit : ICliCommand
{
    public string Name => nameof(Exit);

    public List<string> Aliases => new() { "quit", "close", "terminate", "q" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        brick?.Disconnect();
        Environment.Exit(0);
    }
}
