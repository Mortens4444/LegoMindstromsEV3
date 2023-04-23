using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Subtract : TwoOperatorOperand
{
    public Subtract(byte value1, byte value2)
        : base(value1, value2, OpCode.Sub8)
    { }

    public Subtract(short value1, short value2)
        : base(value1, value2, OpCode.Sub16)
    { }

    public Subtract(int value1, int value2)
        : base(value1, value2, OpCode.Sub32)
    { }

    public Subtract(float value1, float value2)
        : base(value1, value2, OpCode.SubFloat)
    { }
}
