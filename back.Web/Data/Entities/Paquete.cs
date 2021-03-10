

namespace back.Web.Data.Entities
{
    public class Paquete:IEntity
    {
        public int Id { get; set; }

        public int OficinaDestino { get; set; }

        public string DireccionDestino { get; set; }

        public string NombreDestinatario { get; set; }

        public string CedulaDestinatario { get; set; }

        public Municipio Municipio { get; set; }
        public int MunicipioId { get; set; }

        public Contenido Contenido { get; set; }
        public int ContenidoId { get; set; }

        public int Anexo { get; set; }

        public string Asunto { get; set; }

        public int Cantidad { get; set; }

    }
}
