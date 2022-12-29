using JokesApp.BAL;
using Microsoft.AspNetCore.Mvc;

namespace JokesApp.Controllers
{
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {
        private readonly IJokesBusiness _jokesBusiness;

        public JokesController(IJokesBusiness jokesBusiness)
        {
            _jokesBusiness = jokesBusiness;
        }

        [HttpGet("GetRandomJokes")]
        public async Task<IActionResult> GetRandom()
        {
            var result = await _jokesBusiness.GetRandomJokes();
            return Ok(result);
        }

        [HttpGet("GetJokesCount")]
        public async Task<IActionResult> GetCount()
        {
            var result = await _jokesBusiness.GetJokesCount();
            return Ok(result);
        }

    }
}
