using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class MovieCastRepository : BaseRepository<MovieCast>, IMovieCastRepository
    {
        public MovieCastRepository(MovieShopDbContext _con) : base(_con)
        {
        }
    }
}
