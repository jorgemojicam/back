

namespace back.Web.Data
{
    using Entities;
    using System.Linq;

    public interface ICentroCostoRepository : IGenericRepository<CentroCosto>
    {
        IQueryable<CentroCosto> GetByMunicipio();
    }
}
