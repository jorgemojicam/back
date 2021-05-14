

namespace back.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    public class RegionalRepository:GenericRepository<Regional>,IRegionalRepository
    {
        public RegionalRepository(DataContext context) : base(context)
        {

        }

    }
}
