using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace Mindstorms.CLI.Commands
{
    internal class PortList : ICliCommand
    {
        public string Name => nameof(PortList);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            var portNames = SerialPort.GetPortNames();
            var ports = String.Join(Environment.NewLine, portNames);
            Console.WriteLine(ports);
        }
    }
}
