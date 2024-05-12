using System.Text.Json;
using TossInfa.토스결제.RequestModel;
using TossInfa.토스결제.ResponseModel;

namespace TossInfa.토스결제
{
    public class 토스결제APIService
    {
        private readonly HttpClient _httpClient;

        public 토스결제APIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task<T> SendRequestAsync<T>(string url, object request)
        {
            var jsonRequest = JsonSerializer.Serialize(request);
            using var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(requestMessage);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(jsonResponse);
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"API call to {url} failed: {response.StatusCode} - {errorContent}");
            }
        }

        public Task<결제생성Response> 결제생성Async(결제생성Request request) => SendRequestAsync<결제생성Response>("https://pay.toss.im/api/v2/payments", request);

        public Task<HttpResponseMessage> 결제승인Async(결제승인Request request) => SendRequestAsync<HttpResponseMessage>("https://p ay.toss.im/api/v2/execute", request);

        public Task<HttpResponseMessage> 결제환불Async(결제환불Request request) => SendRequestAsync<HttpResponseMessage>("https://pay.toss.im/api/v2/refunds", request);

        public Task<결제상태확인Response> 결제상태확인Async(결제상태확인Request request) => SendRequestAsync<결제상태확인Response>("https://pay.toss.im/api/v2/status", request);
    }
}
