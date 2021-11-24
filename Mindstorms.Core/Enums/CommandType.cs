namespace Mindstorms.Core.Enums
{
    public enum CommandType : byte
	{
		DirectCommand = 0x00,
		SystemCommand = 0x01,
		DirectCommandReply = 0x02,
		SystemCommandReply = 0x03,
		DirectCommandReplyWithError = 0x04,
		SystemCommandReplyWithError = 0x05
	}
}
