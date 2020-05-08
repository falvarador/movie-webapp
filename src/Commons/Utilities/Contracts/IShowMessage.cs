namespace MovieWeb.WebApp.Common
{
    using System.Threading.Tasks;

    public interface IShowMessage
    {
        Task ShowErrorMessage(string message);
    }
}
