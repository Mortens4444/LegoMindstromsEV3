namespace Mindstorms.Core.Enums
{
    public enum SystemCommand : byte
	{
		BeginFileDownload = 0x92,
		ContinueFileDownload = 0x93,
		BeginFileUpload = 0x94,
		ContinueFileUpload = 0x95,
		BeginGetFile = 0x96,
		ContinueGetFile = 0x97,
		CloseFileHandle = 0x98,
		ListFiles = 0x99,
		ContinueListFiles = 0x9A,
		CreateDir = 0x9B,
		DeleteFile = 0x9C,
		ListOpenHandles = 0x9D,
		WriteMailbox = 0x9E,
		BluetoothPin = 0x9F,
		EnterFirmwareUpdate = 0xA0
	}
}
