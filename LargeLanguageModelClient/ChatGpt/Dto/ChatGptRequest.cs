namespace LargeLanguageModelClient.ChatGpt.Dto
{
    public class ChatGptRequest
    {
        public string Model { get; set; } = String.Empty;

        public List<Dictionary<string, string>> Messages { get; set; } = new List<Dictionary<string, string>>();

        public double? Temperature { get; set; }
    }
}
