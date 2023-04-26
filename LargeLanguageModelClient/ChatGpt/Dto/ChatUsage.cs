namespace LargeLanguageModelClient.ChatGpt.Dto
{
    public class ChatUsage
    {
        public int CompletionTokens { get; set; }

        public int PromptTokens { get; set; }

        public int TotalTokens { get; set; }
    }
}
