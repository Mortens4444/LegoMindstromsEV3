namespace LargeLanguageModelClient.ChatGpt.Dto
{
    public class ChatCompletion
    {
        public List<ChatChoice> Choices { get; set; } = new List<ChatChoice>();

        public long Created { get; set; }

        public string Id { get; set; } = String.Empty;

        public string Model { get; set; } = String.Empty;

        public string Object { get; set; } = String.Empty;

        public ChatUsage Usage { get; set; } = new ChatUsage();
    }
}
