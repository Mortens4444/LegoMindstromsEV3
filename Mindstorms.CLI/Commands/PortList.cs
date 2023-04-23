using Mindstorms.Core.EV3;
using System.IO.Ports;

namespace Mindstorms.CLI.Commands;

internal class PortList : ICliCommand
{
    public string Name => nameof(PortList);

    public List<string> Aliases => new() { "list", "ls" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        if (brick == null)
        {
            Console.Error.WriteLine("Use 'connect' before this command.");
        }
        else
        {
            var portNames = SerialPort.GetPortNames();
            var ports = String.Join(Environment.NewLine, portNames);
            Console.WriteLine(ports);
        }
    }
}
