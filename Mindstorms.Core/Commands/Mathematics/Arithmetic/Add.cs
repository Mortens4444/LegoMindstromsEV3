using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Add : TwoOperatorOperand
    {
        public Add(byte value1, byte value2)
            : base (value1, value2, OpCode.Add8)
        { }

        public Add(short value1, short value2)
            : base(value1, value2, OpCode.Add16)
        { }

        public Add(int value1, int value2)
            : base(value1, value2, OpCode.Add32)
        { }

        public Add(float value1, float value2)
            : base(value1, value2, OpCode.AddFloat)
        { }
    }
}
