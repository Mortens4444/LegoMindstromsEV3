namespace Mindstorms.Core.Enums;

public class SystemCommand : EnumLikeObject<SystemCommand>
{
	public static readonly SystemCommand BeginFileDownload = new(0x92, nameof(BeginFileDownload));
	public static readonly SystemCommand ContinueFileDownload = new(0x93, nameof(ContinueFileDownload));
	public static readonly SystemCommand BeginFileUpload = new(0x94, nameof(BeginFileUpload));
	public static readonly SystemCommand ContinueFileUpload = new(0x95, nameof(ContinueFileUpload));
	public static readonly SystemCommand BeginGetFile = new(0x96, nameof(BeginGetFile));
	public static readonly SystemCommand ContinueGetFile = new(0x97, nameof(ContinueGetFile));
	public static readonly SystemCommand CloseFileHandle = new(0x98, nameof(CloseFileHandle));
	public static readonly SystemCommand ListFiles = new(0x99, nameof(ListFiles));
	public static readonly SystemCommand ContinueListFiles = new(0x9A, nameof(ContinueListFiles));
	public static readonly SystemCommand CreateDir = new(0x9B, nameof(CreateDir));
	public static readonly SystemCommand DeleteFile = new(0x9C, nameof(DeleteFile));
	public static readonly SystemCommand ListOpenHandles = new(0x9D, nameof(ListOpenHandles));
	public static readonly SystemCommand WriteMailbox = new(0x9E, nameof(WriteMailbox));
	public static readonly SystemCommand BluetoothPin = new(0x9F, nameof(BluetoothPin));
	public static readonly SystemCommand EnterFirmwareUpdate = new(0xA0, nameof(EnterFirmwareUpdate));

	private SystemCommand(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator SystemCommand(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(SystemCommand value)
	{
		return value.Value;
	}
}
