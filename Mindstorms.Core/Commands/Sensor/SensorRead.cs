using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.Core.Commands.Sensor
{
    public abstract class SensorRead : Command
    {
        public InputSubCode InputSubCode { get; set; }

        protected List<byte> GetData(byte sensorPort, byte sensorType, byte sensorMode, InputSubCode inputSubCode, DaisyChainLayer daisyChainLayer, byte responseSize = 1)
        {
            InputSubCode = inputSubCode;
            var result = new List<byte>
            {
                DirectCommandWithReply,
                4,
                0,
                OpCode.InputDevice,
                inputSubCode,
                daisyChainLayer,
                sensorPort,
                sensorType,
                sensorMode,
                responseSize
            };
            for (int i = 0; i < responseSize; i++)
            {
                result.Add((byte)(i | ParameterType.Variable | VariableScope.Global));
            }
            return result;
        }

        public float GetResult(byte[] response)
        {
            switch (InputSubCode)
            {
                case InputSubCode.ReadyPCTValue:
                    return GetByteResult(response);
                case InputSubCode.ReadyRawValue:
                    return GetIntResult(response);
                case InputSubCode.ReadySIValue:
                    return GetFloatResult(response);
                default:
                    throw new NotImplementedException();
            }
        }

        private float GetFloatResult(byte[] response)
        {
            return BitConverter.ToSingle(response, response.Length - 4);
        }

        private int GetIntResult(byte[] response)
        {
            return BitConverter.ToInt32(response, response.Length - 4);
        }

        private byte GetByteResult(byte[] response)
        {
            return response.Last();
        }
    }
}