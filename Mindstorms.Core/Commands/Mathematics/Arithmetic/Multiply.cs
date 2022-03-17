using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Multiply : TwoOperatorOperand
    {
        public Multiply(byte value1, byte value2)
            : base(value1, value2, OpCode.Mul8)
        { }

        public Multiply(short value1, short value2)
            : base(value1, value2, OpCode.Mul16)
        { }

        public Multiply(int value1, int value2)
            : base(value1, value2, OpCode.Mul32)
        { }

        public Multiply(float value1, float value2)
            : base(value1, value2, OpCode.MulFloat)
        { }
    }
}
