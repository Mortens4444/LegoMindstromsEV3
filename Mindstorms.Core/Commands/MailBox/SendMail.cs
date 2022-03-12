using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.MailBox
{
    public class SendMail : Command
    {
#warning This command must be tested.
        public SendMail(string name, string message)
        {
            data = SystemCommandNoReply;
            data.Add((byte)SystemCommand.WriteMailbox);
            data.Add((byte)name.Length);
            data.Append(name);
            data.Append((ushort)message.Length);
            data.Append(message);
        }
    }
}
