using System;

namespace Mindstorms.Core.Enums
{
    [Flags]
	public enum OutputPort : byte
	{
		A = 0x01,
		B = 0x02,
		C = 0x04,
		D = 0x08
	};
}
