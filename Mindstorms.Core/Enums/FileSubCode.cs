namespace Mindstorms.Core.Enums
{
    public class FileSubCode : EnumLikeObject<FileSubCode>
	{
		public static readonly FileSubCode OpenAppend = new FileSubCode(0x00, nameof(OpenAppend));
		public static readonly FileSubCode OpenRead = new FileSubCode(0x01, nameof(OpenRead));
		public static readonly FileSubCode OpenWrite = new FileSubCode(0x02, nameof(OpenWrite));
		public static readonly FileSubCode ReadValue = new FileSubCode(0x03, nameof(ReadValue));
		public static readonly FileSubCode WriteValue = new FileSubCode(0x04, nameof(WriteValue));
		public static readonly FileSubCode ReadText = new FileSubCode(0x05, nameof(ReadText));
		public static readonly FileSubCode WriteText = new FileSubCode(0x06, nameof(WriteText));
		public static readonly FileSubCode Close = new FileSubCode(0x07, nameof(Close));
		public static readonly FileSubCode LoadImage = new FileSubCode(0x08, nameof(LoadImage));
		public static readonly FileSubCode GetHandle = new FileSubCode(0x09, nameof(GetHandle));
		public static readonly FileSubCode LoadPicture = new FileSubCode(0x0A, nameof(LoadPicture));
		public static readonly FileSubCode GetPool = new FileSubCode(0x0B, nameof(GetPool));
		public static readonly FileSubCode Unload = new FileSubCode(0x0C, nameof(Unload));
		public static readonly FileSubCode GetFolders = new FileSubCode(0x0D, nameof(GetFolders));
		public static readonly FileSubCode GetIcon = new FileSubCode(0x0E, nameof(GetIcon));
		public static readonly FileSubCode GetSubfolderName = new FileSubCode(0x0F, nameof(GetSubfolderName));
		public static readonly FileSubCode WriteLog = new FileSubCode(0x10, nameof(WriteLog));
		public static readonly FileSubCode CloseLog = new FileSubCode(0x11, nameof(CloseLog));
		public static readonly FileSubCode GetImage = new FileSubCode(0x12, nameof(GetImage));
		public static readonly FileSubCode GetItem = new FileSubCode(0x13, nameof(GetItem));
		public static readonly FileSubCode GetCacheFiles = new FileSubCode(0x14, nameof(GetCacheFiles));
		public static readonly FileSubCode PutCacheFile = new FileSubCode(0x15, nameof(PutCacheFile));
		public static readonly FileSubCode GetCacheFile = new FileSubCode(0x16, nameof(GetCacheFile));
		public static readonly FileSubCode DelCacheFile = new FileSubCode(0x17, nameof(DelCacheFile));
		public static readonly FileSubCode DelSubfolder = new FileSubCode(0x18, nameof(DelSubfolder));
		public static readonly FileSubCode GetLogName = new FileSubCode(0x19, nameof(GetLogName));
		public static readonly FileSubCode GetCacheName = new FileSubCode(0x1A, nameof(GetCacheName));
		public static readonly FileSubCode OpenLog = new FileSubCode(0x1B, nameof(OpenLog));
		public static readonly FileSubCode ReadBytes = new FileSubCode(0x1C, nameof(ReadBytes));
		public static readonly FileSubCode WriteBytes = new FileSubCode(0x1D, nameof(WriteBytes));
		public static readonly FileSubCode Remove = new FileSubCode(0x1E, nameof(Remove));
		public static readonly FileSubCode Move = new FileSubCode(0x1F, nameof(Move));

		private FileSubCode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator FileSubCode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(FileSubCode value)
		{
			return value.Value;
		}
	}
}
