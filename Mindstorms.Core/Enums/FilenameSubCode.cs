namespace Mindstorms.Core.Enums
{
    public class FilenameSubCode : EnumLikeObject<FilenameSubCode>
	{
		public static readonly FilenameSubCode Exist = new FilenameSubCode(0x10, nameof(Exist));
		public static readonly FilenameSubCode TotalSize = new FilenameSubCode(0x11, nameof(TotalSize));
		public static readonly FilenameSubCode Split = new FilenameSubCode(0x12, nameof(Split));
		public static readonly FilenameSubCode Merge = new FilenameSubCode(0x13, nameof(Merge));
		public static readonly FilenameSubCode Check = new FilenameSubCode(0x14, nameof(Check));
		public static readonly FilenameSubCode Pack = new FilenameSubCode(0x15, nameof(Pack));
		public static readonly FilenameSubCode Unpack = new FilenameSubCode(0x16, nameof(Unpack));
		public static readonly FilenameSubCode GetFolderName = new FilenameSubCode(0x17, nameof(GetFolderName));

		private FilenameSubCode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator FilenameSubCode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(FilenameSubCode value)
		{
			return value.Value;
		}
	}
}
