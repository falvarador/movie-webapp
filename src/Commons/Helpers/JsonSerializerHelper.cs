namespace MovieWeb.WebApp.Common
{
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    public static class JsonSerializerHelper
    {
        public static async Task<T> DeserializeResponse<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }
    }
}
