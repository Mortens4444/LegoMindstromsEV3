using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Floor : OneOperatorOperand
    {
        public Floor(float value)
            : base(value, MathSubCode.Floor)
        {
        }
    }
}
