

namespace back.Web.Data
{
    using Entities;
    public class PaqueteRepository : GenericRepository<Paquete>, IPaqueteRepository
    {
        public PaqueteRepository(DataContext context) : base(context)
        {

        }
    }
}
