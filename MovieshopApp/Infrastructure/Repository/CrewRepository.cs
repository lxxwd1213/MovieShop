using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class CrewRepository : BaseRepository<Crew>, ICrewRepository
    {
        public CrewRepository(MovieShopDbContext _con) : base(_con)
        {
        }
    }
}
