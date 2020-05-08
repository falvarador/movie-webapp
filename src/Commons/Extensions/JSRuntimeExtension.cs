namespace MovieWeb.WebApp.Common
{
    using System.Threading.Tasks;
    using Microsoft.JSInterop;

    public static class IJSRuntimeExtension
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            await js.InvokeVoidAsync("console.log", "prueba de console.log");
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
