using System.Text;

namespace LargeLanguageModelClient
{
    using System.Text.Json;

    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public static SnakeCaseNamingPolicy Instance { get; } = new SnakeCaseNamingPolicy();

        public override string ConvertName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return name;
            }

            var result = new StringBuilder();
            for (int i = 0; i < name.Length; i++)
            {
                var current = name[i];
                if (i > 0 && Char.IsUpper(current))
                {
                    result.Append('_');
                }
                result.Append(Char.ToLower(current));
            }
            return result.ToString();
        }
    }
}
