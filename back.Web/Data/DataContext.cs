namespace back.Web.Data
{
    using back.Web.Data.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Solicitud> Solicitud { get; set; }

        public DbSet<Paquete> Paquete { get; set; }

        public DbSet<Departamento> Departamento { get; set; }

        public DbSet<Municipio> Municipio { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Contenido> Contenido { get; set; }

        public DbSet<SolicitudPaquete> SolicitudPaquete { get; set; }

        public DbSet<CentroCosto> CentroCosto { get; set; }

        public DbSet<Colaboradores> Colaboradores { get; set; }

        public DbSet<Envios> Envios { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }
    }
}
