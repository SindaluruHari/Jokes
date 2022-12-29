using JokesApp.BAL;
using JokesApp.Configuration;
using JokesApp.Models;
using Microsoft.Extensions.Options;

namespace JokesApp.Concrete
{
    public class JokesBusiness : IJokesBusiness
    {
        private readonly JokesAPI _jokesAPI;
        private readonly IApiService _apiService;
        public JokesBusiness(IOptions<JokesAPI> options, IApiService apiService)
        {
            _jokesAPI = options.Value;
            _apiService = apiService;
        }

        public async Task<JokeModel?> GetRandomJokes()
        {
            var result = await _apiService.GetDataFromAPI<JokeModel>(_jokesAPI.Random);
            return result;
        }

        public async Task<Count?> GetJokesCount()
        {
            var result = await _apiService.GetDataFromAPI<Count>(_jokesAPI.Count);
            return result;
        }
    }
}
