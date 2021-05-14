

namespace back.Web.Data
{
    using back.Web.Data.Entities;
    using Entities;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class SolicitudRepository : GenericRepository<Solicitud>, ISolicitudRepository
    {
        private readonly DataContext context;
        public SolicitudRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable<Solicitud> GetAllEntities()
        {
            return this.context.Solicitud.Include(m => m.CentroCosto);
        }

        public IQueryable<Solicitud> GetMas()
        {
            var clave = new SqlParameter("@p_clave", "cosa");
            var users = context.Solicitud.FromSqlRaw("exec SP_OFICINAGETBY_CLAVE @p_clave", clave).ToList();
            return this.context.Solicitud.Include(m => m.CentroCosto);
        }
    }
}
