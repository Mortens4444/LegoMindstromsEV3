using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Log : OneOperatorOperand
    {
        public Log(float value)
            : base(value, MathSubCode.Log)
        {
        }
    }
}
