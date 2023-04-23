namespace Mindstorms.Core.Enums;

public class FileSubCode : EnumLikeObject<FileSubCode>
{
	public static readonly FileSubCode OpenAppend = new(0x00, nameof(OpenAppend));
	public static readonly FileSubCode OpenRead = new(0x01, nameof(OpenRead));
	public static readonly FileSubCode OpenWrite = new(0x02, nameof(OpenWrite));
	public static readonly FileSubCode ReadValue = new(0x03, nameof(ReadValue));
	public static readonly FileSubCode WriteValue = new(0x04, nameof(WriteValue));
	public static readonly FileSubCode ReadText = new(0x05, nameof(ReadText));
	public static readonly FileSubCode WriteText = new(0x06, nameof(WriteText));
	public static readonly FileSubCode Close = new(0x07, nameof(Close));
	public static readonly FileSubCode LoadImage = new(0x08, nameof(LoadImage));
	public static readonly FileSubCode GetHandle = new(0x09, nameof(GetHandle));
	public static readonly FileSubCode LoadPicture = new(0x0A, nameof(LoadPicture));
	public static readonly FileSubCode GetPool = new(0x0B, nameof(GetPool));
	public static readonly FileSubCode Unload = new(0x0C, nameof(Unload));
	public static readonly FileSubCode GetFolders = new(0x0D, nameof(GetFolders));
	public static readonly FileSubCode GetIcon = new(0x0E, nameof(GetIcon));
	public static readonly FileSubCode GetSubfolderName = new(0x0F, nameof(GetSubfolderName));
	public static readonly FileSubCode WriteLog = new(0x10, nameof(WriteLog));
	public static readonly FileSubCode CloseLog = new(0x11, nameof(CloseLog));
	public static readonly FileSubCode GetImage = new(0x12, nameof(GetImage));
	public static readonly FileSubCode GetItem = new(0x13, nameof(GetItem));
	public static readonly FileSubCode GetCacheFiles = new(0x14, nameof(GetCacheFiles));
	public static readonly FileSubCode PutCacheFile = new(0x15, nameof(PutCacheFile));
	public static readonly FileSubCode GetCacheFile = new(0x16, nameof(GetCacheFile));
	public static readonly FileSubCode DelCacheFile = new(0x17, nameof(DelCacheFile));
	public static readonly FileSubCode DelSubfolder = new(0x18, nameof(DelSubfolder));
	public static readonly FileSubCode GetLogName = new(0x19, nameof(GetLogName));
	public static readonly FileSubCode GetCacheName = new(0x1A, nameof(GetCacheName));
	public static readonly FileSubCode OpenLog = new(0x1B, nameof(OpenLog));
	public static readonly FileSubCode ReadBytes = new(0x1C, nameof(ReadBytes));
	public static readonly FileSubCode WriteBytes = new(0x1D, nameof(WriteBytes));
	public static readonly FileSubCode Remove = new(0x1E, nameof(Remove));
	public static readonly FileSubCode Move = new(0x1F, nameof(Move));

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
