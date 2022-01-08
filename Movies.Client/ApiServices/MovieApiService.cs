using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movieList = new List<Movie>();
            movieList.Add(
                 new Movie
                 {
                     Id=1,
                     Genre ="Comics",
                     Title = "asd",
                     Rating ="9.5",
                     ImageUrl="images/src",
                     ReleaseDate=DateTime.Now,
                     Owner ="swn"
                 }
                );

            return await Task.FromResult(movieList);
               
        }
    }
}
