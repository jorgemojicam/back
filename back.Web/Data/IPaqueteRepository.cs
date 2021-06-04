

namespace back.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    public interface IPaqueteRepository : IGenericRepository<Paquete>
    {
        IList<Paquete> BulkInsert(IList<Paquete> entity);
    }
}
