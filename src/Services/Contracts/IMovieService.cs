namespace MovieWeb.WebApp.Services
{
    using System.Collections.Generic;
    using MovieWeb.WebApp.Model;

    public interface IMovieService : IBaseService
    {
        List<MovieViewModel> GetMovies();
    }
}
