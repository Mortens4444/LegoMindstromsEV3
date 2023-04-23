using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class Disconnect : ICliCommand
{
    public string Name => nameof(Disconnect);

    public List<string> Aliases => new() { "close", "unlink", "detach" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        if (brick == null)
        {
            Console.Error.WriteLine("Use 'connect' before this command.");
        }
        else
        {
            brick.Disconnect();
        }
    }
}
