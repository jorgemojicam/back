

namespace back.Web.Data
{
    using Entities;
    using System.Linq;

    public interface IColaboradoresRepository : IGenericRepository<Colaboradores>
    {
        IQueryable<Colaboradores> GetByCentroCosto();
    }
}
