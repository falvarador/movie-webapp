﻿namespace MovieWeb.WebApp.Services
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(bool error, T response, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public bool Error { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
