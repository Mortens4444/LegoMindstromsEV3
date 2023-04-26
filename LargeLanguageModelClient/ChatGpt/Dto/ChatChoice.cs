namespace LargeLanguageModelClient.ChatGpt.Dto
{
    public class ChatChoice
    {
        public string FinishReason { get; set; } = String.Empty;

        public int Index { get; set; }

        public ChatMessage Message { get; set; } = new ChatMessage();
    }
}
