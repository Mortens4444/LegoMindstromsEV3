﻿using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Program
{
    public class Start : Command
    {
        /// <summary>
        /// Starts an application.
        /// </summary>
        /// <param name="command">The full or relative path of the application to start. Ex.: /home/root/lms2012/prjs/everstorm/everstorm.rbf</param>
        public Start(string command)
        {
            data = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                8,
                0,

                (byte)OpCode.File,
                (byte)FileSubCode.LoadImage
            };

            data.AppendTwoBytesParameter((byte)ProgramSlot.User);
            data.AppendStringParameter(command);
            data.AddRange(new byte[]
            {
                (byte)ParameterType.Variable | (byte)VariableScope.Global, // Return Image Size at Global Var offset 0. Offset encoded as single byte.
                4 | (byte)ParameterType.Variable | (byte)VariableScope.Global, // Return Address of image at Global Var offset 4. Offset encoded as single byte.
                (byte)OpCode.ProgramStart,
                (byte)ProgramSlot.User,
                (byte)ParameterType.Variable | (byte)VariableScope.Global,
                4 | (byte)ParameterType.Variable | (byte)VariableScope.Global,
                (byte)ProgramMode.Normal
            });
        }
    }
}
