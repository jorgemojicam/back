

namespace back.Web.Data
{
    using Entities;
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DataContext context) : base(context)
        {

        }
    }
}
