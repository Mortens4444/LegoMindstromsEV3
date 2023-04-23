namespace Mindstorms.Core.Enums;

public enum CommandReplyStatus
{
    Success = 0x00,
    UnknownHandle = 0x01,
    HandleNotReady = 0x02,
    CorruptFile = 0x03,
    NoHandlesAvailable = 0x04,
    NoPermission = 0x05,
    IllegalPath = 0x06,
    FileExists = 0x07,
    EndOfFile = 0x08,
    SizeError = 0x09,
    UnknownError = 0x0A,
    IllegalFilename = 0x0B,
    IllegalConnection = 0x0C,
    WrongNumberOfBytes = 0x40,
    WrongSequenceNumber = 0x41,

    NoErrorFlagIsPresent = 0xFF
}
