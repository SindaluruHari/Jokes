using JokesApp.Models;

namespace JokesApp.BAL
{
    public interface IJokesBusiness
    {
        Task<JokeModel?> GetRandomJokes();
        Task<Count?> GetJokesCount();
    }
}
