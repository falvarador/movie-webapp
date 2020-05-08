namespace MovieWeb.WebApp.Services
{
    using System.Threading.Tasks;

    public interface IBaseService
    {
        Task<HttpResponseWrapper<object>> DeleteAsync(string url);
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T body);
        Task<HttpResponseWrapper<TResponse>> PostAsync<T, TResponse>(string url, T body);
        Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T body);
    }
}
