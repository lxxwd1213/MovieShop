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
    public class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(MovieShopDbContext _con) : base(_con)
        {
        }

        public IEnumerable<Purchase> GetAll(int pageSize = 30, int page = 1)
        {
            throw new NotImplementedException();
        }
    }
}
