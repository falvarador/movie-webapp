namespace MovieWeb.WebApp.Common
{
    using System.Threading.Tasks;

    public class ShowMessage : IShowMessage
    {
        public async Task ShowErrorMessage(string message)
        {
            await Task.FromResult(0);
        }
    }
}
