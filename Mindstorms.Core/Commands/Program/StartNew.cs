using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Program
{
    public class StartNew : Command
    {
#warning This command must be tested.

        public StartNew()
        {

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,//8,
                0,
                
                //(byte)OpCode.UIWrite,
                //(byte)UIWriteSubCommand.InitRun,

                //(byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                //(byte)ledPattern

                //(byte)ParameterType.Variable | (byte)VariableScope.Global, // Return Image Size at Global Var offset 0. Offset encoded as single byte.
                //4 | (byte)ParameterType.Variable | (byte)VariableScope.Global, // Return Address of image at Global Var offset 4. Offset encoded as single byte.
                //(byte)OpCode.ProgramStart,
                //(byte)ProgramSlot.Cmd,
                //(byte)ParameterType.Variable | (byte)VariableScope.Global,
                //4 | (byte)ParameterType.Variable | (byte)VariableScope.Global,
                //(byte)ProgramMode.Normal

                //(byte)OpCode.UIWrite,
                //0x10

                //(byte)OpCode.UIWrite,
                //0x1F

                //0x4C,
                //0x45,
                //0x47,
                //0x4F,
                //0xA6,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x04,
                //0x00,
                //0x22,
                //0x00,
                //0x00,
                //0x00,
                //0x40,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x76,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x01,
                //0x00,
                //0x01,
                //0x00,
                //0x00,
                //0x00,
                //0x7D,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x01,
                //0x00,
                //0x00,
                //0x00,
                //0x9A,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x00,
                //0x04,
                //0x00,
                //0x00,
                //0x00,

                //0xA2, opOutput_Reset
                //0x00, LAYER
                //0x0F, NOS
                //0x99, opInput_Device
                //0x0A, CLR_ALL
                //0x3F, LAYER
                //0x87, opTimer_Read
                //0x6C, 1
                //0x33, 2
                //0x81, 3
                //0x7B, 4
                //0x70, opJr_Neq8
                //0x33, left
                //0x81, right
                //0x32, 1
                //0x74, 2
                //0x33, 3
                //0x81, 4
                //0x64, opJr_Lt8
                //0x78, left
                //0xC1, right
                //0x04, 1
                //0x10, 2
                //0x7C, 3
                //0xC1, 4
                //0x06, opObject_Trig
                //0x7C, 1
                //0x83, 2
                //0x00, OpError
                //0x00, OpError
                //0x96, opSound_Ready
                //0x42, opJr_True
                //0xC1, 1
                //0x01, 2
                //0x10, 3
                //0x7E, 4
                //0xC1, opArray
                //0x06, FILL
                //0x7E, handle
                //0x01, type
                //0x30, 
                //0x01, 
                //0xE1, 
                //0x20, 
                //0x30, 
                //0x01, 
                //0xE1, 
                //0x21, 
                //0x05, 
                //0x03, 
                //0x0B, 
                //0x40, 
                //0x3D, 
                //0x0A, 
                //0x01, 
                //0x40, 

                //0x30,
                //0x01,
                //0x40,

                //0x08,
                //0x0A,
                //0x09,
                //0x02,
                //0x01,
                //0x40,
                //0x41,
                //0x40,
                //0x39,
                //0x26,
                //0x68,
                //0x83,
                //0xFE,
                //0xFF,
                //0xFF,
                //0xFF,
                //0x68,
                //0x05,
                //0x04,
                //0x07,
                //0x04,
                //0x09,
                //0x02,
                //0x01,
                //0x40,
                //0x42,
                //0x40,
                //0x39,
                //0x40,
                //0x24,
                //0x0A,

                //0x12, //F
                //0x60, //F
                //0x01,
                //0x60,
                //0x3A, //F
                //0x01,
                //0x40,

                //0x26, //Parsed -keys working
                //0x40, //F -no clear
                //0x68,
                //0x44, //F -no clear
                //0x72,
                //0x44,
                //0x00,
                //0x08,

                //(byte)OpCode.ObjectStart,
                //(byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                //0,
                //2,

                //(byte)OpCode.ProgramInfo,
                //(byte)ProgramSubCode.Start,
                //(byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                //(byte)ProgramSlot.User,
                //0x00,
                //(byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                //0x01,
                //0x00,

                0x84,
                0x01,
                //0x30,
                //0x00,
                //0xE1,
                //0x21,
                0x84,
                0x00,

                //0x12,
                //0x64,
                //0x01,
                //0x64,
                //0x0A

            };
        }
    }
}
