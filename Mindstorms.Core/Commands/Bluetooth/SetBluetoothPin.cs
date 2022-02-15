using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class SetBluetoothPin : Command
    {
#warning This command must be tested.
        /// <summary>
        /// This command can only be sent by USB for safety reasons.
        /// </summary>
        /// <param name="macOfPC">Ex.: 1234567890AB</param>
        /// <param name="pin">Ex.: 1234</param>
        public SetBluetoothPin(string macOfPC, string pin)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.BluetoothPin,
                (byte)macOfPC.Length,
            };

            //dataList.Add((byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2);
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(macOfPC));
            dataList.Add(0);

            //dataList.Add((byte)ParameterFormat.Long | (byte)FollowType.OneByte);
            dataList.Add((byte)pin.Length);

            //dataList.Add((byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2);
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(pin));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
