

namespace back.Web.Data
{
    using Entities;
    using System.Linq;

    public interface IEnviosRepository : IGenericRepository<Envios>
    {
        IQueryable<Envios> GetByCentroCosto();
    }
}
