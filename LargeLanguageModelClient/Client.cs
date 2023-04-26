using System.Net.Http.Headers;
using System.Text;

namespace LargeLanguageModelClient
{
    public abstract class Client
    {
        public abstract string ServerUrl { get; }

        public virtual async Task<string> SendMessage(string message, string username, string password)
        {
            using var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromMinutes(5);
            httpClient.DefaultRequestHeaders.Authorization = GetAuthenticationHeaderValue(username, password);

            var requestContent = GetRequestContent(message);

            var response = await httpClient.PostAsync(ServerUrl, requestContent);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return ParseResponse(responseContent);
            }

            return $"{response.StatusCode}: {response.ReasonPhrase} - {responseContent}";
        }

        public virtual string ParseResponse(string message)
        {
            return message;
        }

        public virtual StringContent GetRequestContent(string message)
        {
            return new StringContent(message);
        }

        public virtual AuthenticationHeaderValue GetAuthenticationHeaderValue(string username, string password)
        {
            string credentials = $"{username}:{password}";
            byte[] credentialsBytes = Encoding.ASCII.GetBytes(credentials);
            string credentialsBase64 = Convert.ToBase64String(credentialsBytes);
            return new AuthenticationHeaderValue("Basic", credentialsBase64);
        }

        public virtual string GetResponse(string responseContent)
        {
            return responseContent;
        }
    }
}
