using System;

namespace Mindstorms.Core.Enums
{
    /// <summary>
    /// Encoded Parameter type
    /// </summary>
    [Flags]
	public enum ParameterType : byte
	{
		Constant = 0x00,
		Variable = 0x40
	}
}
