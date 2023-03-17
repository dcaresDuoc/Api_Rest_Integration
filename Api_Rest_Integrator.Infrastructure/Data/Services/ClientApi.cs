using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace Api_Rest_Integrator.Infrastructure.Data.Services
{
    public abstract class ClientApi
    {
        protected readonly HttpClient _httpClient;        
        private readonly string _baseRouter;

        public abstract HttpClient configHttpClient();
        public abstract string configBaseRoute();


        public ClientApi()
        {
            _baseRouter = this.configBaseRoute();
            _httpClient = this.configHttpClient();
        }

        protected async Task<TReturn?> GetReturnAsync<TReturn>(string relativeUrl)
        {
            HttpResponseMessage res = await _httpClient.GetAsync($"{_baseRouter}/{relativeUrl}");
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            if (res.IsSuccessStatusCode)
            {
                if (res.StatusCode == HttpStatusCode.NoContent)                
                    return default;
                else if (res.IsSuccessStatusCode)
                    return await res.Content.ReadFromJsonAsync<TReturn>(options);
                else return default;                
            }
            else
            {
                string msg = await res.Content.ReadAsStringAsync();
                Console.WriteLine(msg);
                throw new Exception(msg);
            }
        }

    }
}
