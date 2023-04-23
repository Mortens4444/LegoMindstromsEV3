using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class Beep : ICliCommand
{
    public string Name => nameof(Beep);

    public List<string> Aliases => new() { "tone", "ping", "bleep", "chirp" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        if (brick == null)
        {
            Console.Error.WriteLine("Use 'connect' before this command.");
        }
        else
        {
            var frequency = Convert.ToUInt16(arguments[0]);
            var durationMs = Convert.ToUInt16(arguments[1]);
            brick.Beep(frequency, durationMs);
        }
    }
}
