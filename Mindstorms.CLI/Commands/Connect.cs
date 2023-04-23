using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class Connect : ICliCommand
{
    public string Name => nameof(Connect);

    public List<string> Aliases => new() { "open", "link", "join", "attach", "bind" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        brick?.Disconnect();
        var args = arguments.ToList();
        brick = args.Count == 1 ? new Brick(args[0]) : new Brick(args[0], args[1]);
        brick.Connect();
        Console.WriteLine("Succesfully connected.");
    }
}
