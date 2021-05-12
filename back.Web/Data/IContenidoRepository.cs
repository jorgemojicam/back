

namespace back.Web.Data
{
    using Entities;
    using System.Linq;

    public interface IContenidoRepository : IGenericRepository<Contenido>
    {
        IQueryable<Contenido> GetByCategoria();
    }
}
