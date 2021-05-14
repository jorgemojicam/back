

namespace back.Web.Data
{
    using back.Web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class ColaboradoresRepository : GenericRepository<Colaboradores>, IColaboradoresRepository
    {
        private readonly DataContext context;

        public ColaboradoresRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable<Colaboradores> GetByCentroCosto()
        {
            return this.context.Colaboradores.Include(m => m.CentroCosto);
        }

      
    }
}
