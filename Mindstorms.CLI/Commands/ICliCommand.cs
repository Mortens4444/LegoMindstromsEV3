using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal interface ICliCommand
{
    string Name { get; }

    List<string> Aliases { get; }

    void Action(ref Brick? brick, IList<string> arguments);
}
