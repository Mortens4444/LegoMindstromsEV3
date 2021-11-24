using System;

namespace Mindstorms.Core.Enums
{
    [Flags]
	public enum VariableType : byte
	{
		Value = 0x00,
		Handle = 0x10
	}
}
