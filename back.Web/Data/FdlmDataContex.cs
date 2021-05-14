

namespace back.Web.Data
{
    using back.Web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    public class FdlmDataContex : DbContext
    {
        public DbSet<Sucursales> Sucursales { get; set; }


        public FdlmDataContex(DbContextOptions<FdlmDataContex> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
