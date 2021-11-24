using System;

namespace Mindstorms.Core.Enums
{
    [Flags]
	public enum VariableScope : byte
	{
		Local = 0x00,
		Global = 0x20
	}
}
