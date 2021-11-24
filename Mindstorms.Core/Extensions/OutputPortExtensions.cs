using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Extensions
{
    public static class OutputPortExtensions
    {
        public static int GetIndex(this OutputPort outputPort)
        {
            return (int)Math.Log((byte)outputPort, 2);
        }
    }
}
