

namespace back.Web.Data
{
    using Entities;
    using System.Linq;

    public interface ISolicitudPaqueteRepository : IGenericRepository<SolicitudPaquete>
    {
        IQueryable<SolicitudPaquete> GetByPaquete();
    }
}
