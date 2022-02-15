﻿using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    /// <summary>
    /// Get the name of the brick.
    /// </summary>
    public class IsActive : Command
    {
#warning This command must be tested.
        public IsActive(CommunicationInterface communicationInterface)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                64,
                0,

                (byte)OpCode.ComGet,
                (byte)ComGetSubCommand.GetOnOff,
                (byte)communicationInterface,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
