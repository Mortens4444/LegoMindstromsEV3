using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.System
{
    /// <summary>
    /// Get the name of the brick.
    /// </summary>
    public class GetPin : Command
    {
        public GetPin(CommunicationInterface communicationInterface, string brickName)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                Constants.DefaultResponseLength,
                0,

                (byte)OpCode.ComGet,
                (byte)ComGetSubCommand.GetPin,
                (byte)communicationInterface,

                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(brickName));
            dataList.Add(0);

            dataList.Add(Constants.DefaultResponseLength);
            dataList.Add((byte)ParameterType.Variable | (byte)VariableScope.Global);

            data = dataList.ToArray();
        }
    }
}
