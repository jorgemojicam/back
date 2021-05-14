

namespace back.Web.Data
{
    using Entities;
    using System.Linq;

    public interface ISolicitudRepository:IGenericRepository<Solicitud>
    {
        IQueryable<Solicitud> GetAllEntities();
    }
}
