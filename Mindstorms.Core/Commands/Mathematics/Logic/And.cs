using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class And : TwoOperatorOperand
    {
        public And(byte value1, byte value2)
            : base (value1, value2, OpCode.And8)
        { }

        public And(short value1, short value2)
            : base(value1, value2, OpCode.And16)
        { }

        public And(int value1, int value2)
            : base(value1, value2, OpCode.And32)
        { }
    }
}
