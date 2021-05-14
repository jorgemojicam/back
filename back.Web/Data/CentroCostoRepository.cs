

namespace back.Web.Data
{
    using back.Web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class CentroCostoRepository : GenericRepository<CentroCosto>, ICentroCostoRepository
    {
        private readonly DataContext context;

        public CentroCostoRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable<CentroCosto> GetByMunicipio()
        {
            return this.context.CentroCosto.Include(m => m.Municipio).Include(r => r.Regional);
        }

      
    }
}
