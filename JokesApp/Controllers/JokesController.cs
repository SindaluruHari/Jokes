using JokesApp.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace JokesApp.Controllers
{
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {

        private readonly ILogger<JokesController> _logger;
        private readonly IJokesBusiness _jokesBusiness;

        public JokesController(ILogger<JokesController> logger, IJokesBusiness jokesBusiness)
        {
            _jokesBusiness = jokesBusiness;
            _logger = logger;
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
