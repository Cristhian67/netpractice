using P2.DTOs;
using System.Text.Json;

namespace P2.Services
{
    public class PostService : IPostService
    {
        private HttpClient _httpCLient;

        public PostService(HttpClient httpClient)
        {
            _httpCLient = httpClient;
        }
        public async Task<IEnumerable<PostDTO>> Get()
        {
            
            var result = await _httpCLient.GetAsync(_httpCLient.BaseAddress);

            var body = await result.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var post = JsonSerializer.Deserialize<IEnumerable<PostDTO>>(body, options);

            return post;
        }
    }
}
