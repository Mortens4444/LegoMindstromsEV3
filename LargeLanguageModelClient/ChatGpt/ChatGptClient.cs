using LargeLanguageModelClient.ChatGpt.Dto;
using System.Net.Http.Headers;
using System.Text.Json;

namespace LargeLanguageModelClient.ChatGpt
{
    public class ChatGptClient : JsonSerializerClient
    {
        public override string ServerUrl => "https://api.openai.com/v1/chat/completions";

        public string ModelName { get; }

        public ChatGptClient(string modelName)
        {
            ModelName = modelName;
        }

        public Task<string> SendMessage(ChatGptRequest chatGptRequest, string apiKey)
        {
            return base.SendMessage(ProcessRequest(chatGptRequest), "Bearer", apiKey);
        }

        public Task<string> SendMessage(string message, string apiKey, double temperature = 0.1)
        {
            var request = new ChatGptRequest
            {
                Model = ModelName,
                Temperature = temperature,
                Messages = new List<Dictionary<string, string>>{
                    new Dictionary<string, string> {
                        { "role", "user" },
                        { "content", message }
                    }
                }
            };

            return base.SendMessage(ProcessRequest(request), "Bearer", apiKey);
        }

        public override string GetResponse(string responseContent)
        {
            var apiResponse = ProcessResponse<ApiResponse>(responseContent);
            return apiResponse?.Choices?.FirstOrDefault()?.Text ?? String.Empty;
        }

        public override string ParseResponse(string message)
        {
            var jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
            };
            var chatCompletion = JsonSerializer.Deserialize<ChatCompletion>(message, jsonSerializerOptions);
            return chatCompletion?.Choices[Random.Shared.Next(chatCompletion.Choices.Count)].Message.Content ?? String.Empty;
        }

        public override AuthenticationHeaderValue GetAuthenticationHeaderValue(string authenticationType, string apiKey)
        {
            return new AuthenticationHeaderValue(authenticationType, apiKey);
        }
    }
}