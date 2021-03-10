

namespace back.Web.Data
{
    using Entities;
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(DataContext context) : base(context)
        {

        }
    }
}
