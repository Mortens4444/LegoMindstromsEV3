using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Xor : TwoOperatorOperand
{
    public Xor(byte value1, byte value2)
        : base (value1, value2, OpCode.Xor8)
    { }

    public Xor(short value1, short value2)
        : base(value1, value2, OpCode.Xor16)
    { }

    public Xor(int value1, int value2)
        : base(value1, value2, OpCode.Xor32)
    { }
}
