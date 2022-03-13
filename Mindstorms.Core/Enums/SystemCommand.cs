namespace Mindstorms.Core.Enums
{
    public class SystemCommand : EnumLikeObject<SystemCommand>
	{
		public static readonly SystemCommand BeginFileDownload = new SystemCommand(0x92, nameof(BeginFileDownload));
		public static readonly SystemCommand ContinueFileDownload = new SystemCommand(0x93, nameof(ContinueFileDownload));
		public static readonly SystemCommand BeginFileUpload = new SystemCommand(0x94, nameof(BeginFileUpload));
		public static readonly SystemCommand ContinueFileUpload = new SystemCommand(0x95, nameof(ContinueFileUpload));
		public static readonly SystemCommand BeginGetFile = new SystemCommand(0x96, nameof(BeginGetFile));
		public static readonly SystemCommand ContinueGetFile = new SystemCommand(0x97, nameof(ContinueGetFile));
		public static readonly SystemCommand CloseFileHandle = new SystemCommand(0x98, nameof(CloseFileHandle));
		public static readonly SystemCommand ListFiles = new SystemCommand(0x99, nameof(ListFiles));
		public static readonly SystemCommand ContinueListFiles = new SystemCommand(0x9A, nameof(ContinueListFiles));
		public static readonly SystemCommand CreateDir = new SystemCommand(0x9B, nameof(CreateDir));
		public static readonly SystemCommand DeleteFile = new SystemCommand(0x9C, nameof(DeleteFile));
		public static readonly SystemCommand ListOpenHandles = new SystemCommand(0x9D, nameof(ListOpenHandles));
		public static readonly SystemCommand WriteMailbox = new SystemCommand(0x9E, nameof(WriteMailbox));
		public static readonly SystemCommand BluetoothPin = new SystemCommand(0x9F, nameof(BluetoothPin));
		public static readonly SystemCommand EnterFirmwareUpdate = new SystemCommand(0xA0, nameof(EnterFirmwareUpdate));

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
}
