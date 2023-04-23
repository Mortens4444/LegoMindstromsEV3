using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class Help : ICliCommand
{
    public string Name => nameof(Help);

    public List<string> Aliases => new() { "?", "h", "examples" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        if (brick == null)
        {
            Console.Error.WriteLine("Use 'connect' before this command.");
        }
        else
        {
            var lines = File.ReadAllLines("Commands.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
