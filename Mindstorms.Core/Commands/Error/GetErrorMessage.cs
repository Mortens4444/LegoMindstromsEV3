using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Error
{
    public class GetErrorMessage : Command
    {
        public GetErrorMessage(byte errrorCode)
        {
            data = GetDirectCommandWithReply(Constants.DefaultStringLength);
            data.AddRange(new byte[]
            {
                OpCode.Info,
                InfoSubCode.GetErrorText,
                errrorCode,
                Constants.DefaultStringLength,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
