using JokesApp.Models;

namespace JokesApp.Concrete
{
    public interface IJokesBusiness
    {
        Task<JokeModel?> GetRandomJokes();
        Task<Count?> GetJokesCount();
    }

    public class JokesBusiness : IJokesBusiness
    {
        public async Task<JokeModel?> GetRandomJokes()
        {
            var result = await ApiService.GetDataFromAPI<JokeModel>("https://dad-jokes.p.rapidapi.com/random/joke");
            return result;
        }

        public async Task<Count?> GetJokesCount()
        {
            var result = await ApiService.GetDataFromAPI<Count>("https://dad-jokes.p.rapidapi.com/joke/count");
            return result;
        }
    }
}
