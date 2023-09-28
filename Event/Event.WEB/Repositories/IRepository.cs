namespace Event.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);

        Task<HttpResponseWrapper<object>> Get(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);

       

    }
}
