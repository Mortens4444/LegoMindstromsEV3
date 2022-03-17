using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Divide : TwoOperatorOperand
    {
        public Divide(byte value1, byte value2)
            : base(value1, value2, OpCode.Div8)
        { }

        public Divide(short value1, short value2)
            : base(value1, value2, OpCode.Div16)
        { }

        public Divide(int value1, int value2)
            : base(value1, value2, OpCode.Div32)
        { }

        public Divide(float value1, float value2)
            : base(value1, value2, OpCode.DivFloat)
        { }
    }
}
