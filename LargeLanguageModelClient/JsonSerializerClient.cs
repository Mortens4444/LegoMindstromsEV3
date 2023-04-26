using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace LargeLanguageModelClient
{
    public abstract class JsonSerializerClient : Client
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public override StringContent GetRequestContent(string message)
        {
            return new StringContent(message, Encoding.UTF8, MediaTypeNames.Application.Json);
        }

        public static string ProcessRequest<TResponseType>(TResponseType requestContent)
        {
            return JsonSerializer.Serialize(requestContent, jsonSerializerOptions);
        }

        public static TResponseType? ProcessResponse<TResponseType>(string responseContent)
        {
            return JsonSerializer.Deserialize<TResponseType>(responseContent, jsonSerializerOptions);
        }

        public override string GetResponse(string responseContent)
        {
            return ProcessResponse<object>(responseContent)?.ToString() ?? String.Empty;
        }
    }
}
