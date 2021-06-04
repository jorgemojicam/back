

namespace back.Web.Data
{
    using back.Web.Data.Entities;

    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class EnviosRepository : GenericRepository<Envios>, IEnviosRepository
    {
        private readonly DataContext context;

        public EnviosRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
        IQueryable<Envios> IEnviosRepository.GetByCentroCosto()
        {
            return this.context.Envios.Include(m => m.CentroCosto);
        }
    }
}
