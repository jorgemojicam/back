

namespace back.Web.Data
{
    using back.Web.Data.Entities;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipioRepository
    {
        private readonly DataContext context;

        public MunicipioRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
        IQueryable<Municipio> IMunicipioRepository.GetByDepartamento()
        {
            return this.context.Municipio.Include(m => m.Departamento);
        }
    }
}
