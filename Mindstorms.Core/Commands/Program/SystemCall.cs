using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Program
{
    public class SystemCall : Command
    {
#warning This command must be tested.
        public SystemCall(string command)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                1,
                16,

                (byte)OpCode.System,
                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(command));
            dataList.Add(0);

            dataList.Add((byte)ParameterType.Variable | (byte)VariableScope.Local);
            dataList.Add((byte)OpCode.Move8_8);
            dataList.Add(1 | (byte)ParameterType.Variable | (byte)VariableScope.Local);
            dataList.Add((byte)ParameterType.Variable | (byte)VariableScope.Global);

            data = dataList.ToArray();
        }
    }
}
