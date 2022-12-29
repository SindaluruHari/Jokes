using JokesApp.BAL;
using JokesApp.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace JokesApp.Concrete
{
    public class ApiService : IApiService
    {
        private readonly ApiCreds _apiCreds;
        public ApiService(IOptions<ApiCreds> options)
        {
            _apiCreds = options.Value;
        }

        //public async Task<T1?> GetDataFromAPI<T1>(string resourceURL) where T1 : class
        //{
        //    var client = new HttpClient();
        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Get,
        //        RequestUri = new Uri(resourceURL),
        //        Headers =
        //        {
        //            { "X-RapidAPI-Key", "3c28c071b9msh98aeb3623277793p1bdcb4jsn6db1ba0a4d97" },
        //            { "X-RapidAPI-Host", "dad-jokes.p.rapidapi.com" }
        //        }
        //    };

        //    using (var response = await client.SendAsync(request))
        //    {
        //        response.EnsureSuccessStatusCode();
        //        var body = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<T1>(body);
        //    }
        //}
        public async Task<T1?> GetDataFromAPI<T1>(string resourceURL)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(resourceURL),
                Headers =
                    {
                        { "X-RapidAPI-Key", _apiCreds.Key },
                        { "X-RapidAPI-Host", _apiCreds.Host }
                    }
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T1>(body);
            }
        }
    }
}
