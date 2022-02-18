using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.Program
{
#warning This command must be tested.
    public class GetInfo : Command
    {
        public GetInfo(ushort programSlotId)
        {
            var programSlotIdBytes = BitConverter.GetBytes(programSlotId);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                1,
                0,

                (byte)OpCode.ProgramInfo,
                //(byte)ProgramSlot.User,

                programSlotIdBytes[0],
                programSlotIdBytes[1],

                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
