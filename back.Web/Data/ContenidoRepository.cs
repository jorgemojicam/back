

namespace back.Web.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class ContenidoRepository : GenericRepository<Contenido>, IContenidoRepository
    {
        private readonly DataContext context;

        public ContenidoRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        IQueryable<Contenido> IContenidoRepository.GetByCategoria()
        {
            return this.context.Contenido.Include(m => m.Categoria);
        }

    }
}
