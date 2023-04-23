using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Utils;

public static class EnumExtensions
{
    public static string GetDescription<T>(this T enumerationValue)
      where T : Enum
    {
        var type = enumerationValue.GetType();
        if (!type.IsEnum)
        {
            throw new ArgumentException($"{nameof(enumerationValue)} must be of Enum type", nameof(enumerationValue));
        }
        var memberInfo = type.GetMember(enumerationValue.ToString());
        if (memberInfo.Length > 0)
        {
            var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return ((DescriptionAttribute)attributes[0]).Description;
            }
        }

        return enumerationValue.ToString();
    }
}
