﻿namespace Mindstorms.Core.Enums
{
    public class FollowType : EnumLikeObject<FollowType>
    {
		public static readonly FollowType OneByte = new FollowType(0x01, nameof(OneByte));
		public static readonly FollowType TwoBytes = new FollowType(0x02, nameof(TwoBytes));
		public static readonly FollowType FourBytes = new FollowType(0x03, nameof(FourBytes));
		public static readonly FollowType TerminatedString = new FollowType(0x00, nameof(TerminatedString));
		public static readonly FollowType TerminatedString2 = new FollowType(0x04, nameof(TerminatedString2));

		private FollowType(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator FollowType(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(FollowType value)
		{
			return value.Value;
		}
	}
}
