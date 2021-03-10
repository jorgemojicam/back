

namespace back.Web.Data
{
    using Entities;
    public class SolicitudRepository : GenericRepository<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(DataContext context) : base(context)
        {

        }
    }
}
