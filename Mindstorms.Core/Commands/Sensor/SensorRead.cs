using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Sensor;

public abstract class SensorRead : Command
{
    public InputSubCode InputSubCode { get; set; } = InputSubCode.GetRaw;

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
        return (byte)InputSubCode switch
        {
            InputSubCode.ReadyPCTValue => GetByteResult(response),
            InputSubCode.ReadyRawValue => GetIntResult(response),
            InputSubCode.ReadySIValue => GetFloatResult(response),
            _ => throw new NotImplementedException(),
        };
    }

    private static float GetFloatResult(byte[] response)
    {
        return BitConverter.ToSingle(response, response.Length - 4);
    }

    private static int GetIntResult(byte[] response)
    {
        return BitConverter.ToInt32(response, response.Length - 4);
    }

    private static byte GetByteResult(byte[] response)
    {
        return response.Last();
    }
}