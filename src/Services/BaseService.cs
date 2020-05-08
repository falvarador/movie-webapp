namespace MovieWeb.WebApp.Services
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using MovieWeb.WebApp.Common;

    public class BaseService : IBaseService
    {
        private readonly HttpClient _httpClient;

        public BaseService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));;
        }

        private JsonSerializerOptions DefaultJsonOptions => new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public async Task<HttpResponseWrapper<object>> DeleteAsync(string url)
        {
            var httpResponse = await _httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(!httpResponse.IsSuccessStatusCode, null, httpResponse);
        }

        public async Task<HttpResponseWrapper<T>> GetAsync<T>(string url)
        {
            var httpResponse = await _httpClient.GetAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await JsonSerializerHelper.DeserializeResponse<T>(httpResponse, DefaultJsonOptions);
                return new HttpResponseWrapper<T>(false, response, httpResponse);
            }
            else
            {
                return new HttpResponseWrapper<T>(true, default, httpResponse);
            }
        }

        public async Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T body)
        {
            var json = JsonSerializer.Serialize(body);
            var contentType = new StringContent(json, Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.PostAsync(url, contentType);
            return new HttpResponseWrapper<object>(!httpResponse.IsSuccessStatusCode, null, httpResponse);
        }

        public async Task<HttpResponseWrapper<TResponse>> PostAsync<T, TResponse>(string url, T body)
        {
            var json = JsonSerializer.Serialize(body);
            var contentType = new StringContent(json, Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.PostAsync(url, contentType);
            
            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await JsonSerializerHelper.DeserializeResponse<TResponse>(httpResponse, DefaultJsonOptions);
                return new HttpResponseWrapper<TResponse>(false, response, httpResponse);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(true, default, httpResponse);
            }
        }

        public async Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T body)
        {
            var json = JsonSerializer.Serialize(body);
            var contentType = new StringContent(json, Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.PutAsync(url, contentType);
            return new HttpResponseWrapper<object>(!httpResponse.IsSuccessStatusCode, null, httpResponse);
        }

        // public List<Pelicula> ObtenerPeliculas()
        // {
        //     return new List<Pelicula>()
        //     {
        //         new Pelicula(){Titulo = "Spider-Man: Far From Home",
        //             Lanzamiento  = new DateTime(2019, 7, 2),
        //         Poster = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
        //         new Pelicula(){Titulo = "Moana", Lanzamiento  = new DateTime(2016, 11, 23),
        //         Poster = "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_UX182_CR0,0,182,268_AL_.jpg"},
        //         new Pelicula(){Titulo = "Inception", Lanzamiento  = new DateTime(2010, 7, 16),
        //         Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg"}
        //     };
        // }
    }
}
