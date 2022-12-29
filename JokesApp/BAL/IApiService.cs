namespace JokesApp.BAL
{
    public interface IApiService
    {
        Task<T1?> GetDataFromAPI<T1>(string resourceURL);
    }
}
