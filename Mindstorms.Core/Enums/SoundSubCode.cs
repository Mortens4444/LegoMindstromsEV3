﻿namespace Mindstorms.Core.Enums;

public class SoundSubCode : EnumLikeObject<SoundSubCode>
{
	public static readonly SoundSubCode Break = new(0x00, nameof(Break));
	public static readonly SoundSubCode Tone = new(0x01, nameof(Tone));
	public static readonly SoundSubCode Play = new(0x02, nameof(Play));
	public static readonly SoundSubCode Repeat = new(0x03, nameof(Repeat));
	public static readonly SoundSubCode Service = new(0x04, nameof(Service));

	private SoundSubCode(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator SoundSubCode(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(SoundSubCode value)
	{
		return value.Value;
	}
}
