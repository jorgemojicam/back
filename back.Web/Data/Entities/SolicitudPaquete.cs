
namespace back.Web.Data.Entities
{
    public class SolicitudPaquete : IEntity
    {
        public int Id { get; set; }

        public Solicitud Solicitud { get; set; }

        public Paquete Paquete { get; set; }

        public int SolicitudId { get; set; }

        public int PaqueteId { get; set; }

        public int? RecibidoCad { get; set; }

        public int? RecibidoOficina { get; set; }

        public int? RecibidoSA { get; set; }

        public int? RecibidoREC { get; set; }

    }
}
