//using Mindstorms.Core.Enums;

//namespace Mindstorms.Core.Commands.Sensor;

//public class FollowLine : Command
//{
//    private readonly VariableScope scope = VariableScope.Local;

//    public FollowLine(DaisyChainLayer daisyChainLayer, SensorPort sensorPort)
//    {
//        data = new List<byte>
//        {
//            CommandType.DirectCommand | Response.NotExpected,
//            0,
//            3,

//            OpCode.InputRead,
//            daisyChainLayer,
//            sensorPort,
//            SensorType.NXTLight,
//            1,
//            ParameterType.Variable | scope,

//            OpCode.Div8,
//            ParameterType.Variable | scope,
//            2,
//            ParameterType.Variable | scope,

//            OpCode.Add8,
//            ParameterType.Variable | scope,
//            15,
//            ParameterType.Variable | scope,

//            OpCode.InputRead,
//            daisyChainLayer,
//            sensorPort,
//            SensorType.NXTLight,
//            1,
//            1 | ParameterType.Variable | scope,

//            OpCode.Sub8,
//            1 | ParameterType.Variable | scope,
//            ParameterType.Variable | scope,
//            1 | ParameterType.Variable | scope,

//            OpCode.Div8,
//            1 | ParameterType.Variable | scope,
//            2,
//            1 | ParameterType.Variable | scope,

//            OpCode.Add8,
//            40,
//            1 | ParameterType.Variable | scope,
//            2 | ParameterType.Variable | scope,

//            OpCode.Sub8,
//            40,
//            1 | ParameterType.Variable | scope,
//            3 | ParameterType.Variable | scope,

//            OpCode.OutputPower,
//            daisyChainLayer,
//            OutputPort.B,
//            3 | ParameterType.Variable | scope,

//            OpCode.OutputPower,
//            daisyChainLayer,
//            OutputPort.C,
//            2 | ParameterType.Variable | scope,

//            OpCode.OutputStart,
//            daisyChainLayer,
//            OutputPort.BC,

//            OpCode.Jr,
//            0xFF,
//            0xFF,
//            0xFF,
//            217,

//            OpCode.ObjectEnd
//        };
//    }
//}
