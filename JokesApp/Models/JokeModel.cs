namespace JokesApp.Models
{
    public class JokeModel : ResponseBase
    {
        public List<Joke> body { get; set; }
    }

    public class Joke
    {
        public string _id { get; set; }
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }

    }
}
