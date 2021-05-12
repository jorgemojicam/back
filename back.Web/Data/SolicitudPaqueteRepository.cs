

namespace back.Web.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class SolicitudPaqueteRepository : GenericRepository<SolicitudPaquete>, ISolicitudPaqueteRepository
    {
        private readonly DataContext context;
        public SolicitudPaqueteRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        IQueryable<SolicitudPaquete> ISolicitudPaqueteRepository.GetByPaquete()
        {
            return this.context.SolicitudPaquete.Include(m => m.Solicitud).Include(p => p.Paquete);
        }
    }
}
