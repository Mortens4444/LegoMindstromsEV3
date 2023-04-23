using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class Led : ICliCommand
{
    public string Name => nameof(Led);

    public List<string> Aliases => new();

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        if (brick == null)
        {
            Console.Error.WriteLine("Use 'connect' before this command.");
        }
        else
        {
            var ledPattern = LedPattern.Parse(arguments[0]) ?? LedPattern.OrangePulse;
            brick.ChangeLedsState(ledPattern);
        }
    }
}
