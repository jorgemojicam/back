

namespace back.Web.Data
{
    using back.Web.Data.Entities;
    using EFCore.BulkExtensions;
    using Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PaqueteRepository : GenericRepository<Paquete>, IPaqueteRepository
    {
        private readonly DataContext context;
        public PaqueteRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IList<Paquete> BulkInsert(IList<Paquete> entity)
        {
            Task.Run(async () => await this.context.BulkInsertAsync(entity));
            return entity;
        }
    }
}
