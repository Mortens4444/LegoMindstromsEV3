using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File;

public class SetBluetoothPin : Command
{
#warning This command must be tested.
    /// <summary>
    /// This command can only be sent by USB for safety reasons.
    /// </summary>
    /// <param name="macOfPC">Ex.: 1234567890AB</param>
    /// <param name="pin">Ex.: 1234</param>
    public SetBluetoothPin(string macOfPC, string pin)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.BluetoothPin);
        data.Add((byte)macOfPC.Length);

        //data.AppendStringParameter(macOfPC)
        data.Append(macOfPC);

        //data.AppendOneBytesParameter((byte)pin.Length);
        data.Add((byte)pin.Length);

        //data.AppendStringParameter(pin)
        data.Append(pin);
    }
}
