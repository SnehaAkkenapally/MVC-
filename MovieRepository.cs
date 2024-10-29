using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public IEnumerable<MovieCardModel> GetTopMovies()
        {
            return new List<MovieCardModel>
            {
                new MovieCardModel { Id = 1, Title = "Inception" },
                new MovieCardModel { Id = 2, Title = "The Matrix" }
            };
        }
    }
}
