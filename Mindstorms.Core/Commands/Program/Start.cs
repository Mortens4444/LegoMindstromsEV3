using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Program;

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
            CommandType.DirectCommand | Response.NotExpected,
            8,
            0,

            OpCode.File,
            FileSubCode.LoadImage
        };

        data.AppendTwoBytesParameter(ProgramSlot.User);
        data.AppendStringParameter(command);
        data.AddRange(new byte[]
        {
            ParameterType.Variable | VariableScope.Global, // Return Image Size at Global Var offset 0. Offset encoded as single byte.
            4 | ParameterType.Variable | VariableScope.Global, // Return Address of image at Global Var offset 4. Offset encoded as single byte.
            OpCode.ProgramStart,
            ProgramSlot.User,
            ParameterType.Variable | VariableScope.Global,
            4 | ParameterType.Variable | VariableScope.Global,
            ProgramMode.Normal
        });
    }
}
