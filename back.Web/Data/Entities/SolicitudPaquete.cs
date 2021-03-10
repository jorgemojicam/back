
namespace back.Web.Data.Entities
{
    public class SolicitudPaquete : IEntity
    {
        public int Id { get; set; }
        public Solicitud Solicitud { get; set; }
        public Paquete Paquete { get; set; }
    }
}
