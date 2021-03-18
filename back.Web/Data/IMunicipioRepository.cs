

namespace back.Web.Data
{
    using Entities;
    using System.Linq;

    public interface IMunicipioRepository : IGenericRepository<Municipio>
    {
        IQueryable<Municipio> GetByDepartamento();
    }
}
