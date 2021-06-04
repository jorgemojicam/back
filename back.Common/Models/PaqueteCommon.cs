namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class PaqueteCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("oficinaDestino")]
        public int OficinaDestino { get; set; }

        [JsonProperty("oficinaOrigen")]
        public int OficinaOrigen { get; set; }

        [JsonProperty("direccionDestino")]
        public string DireccionDestino { get; set; }

        [JsonProperty("nombreDestinatario")]
        public string NombreDestinatario { get; set; }

        [JsonProperty("cedulaDestinatario")]
        public int CedulaDestinatario { get; set; }

        [JsonProperty("municipio")]
        public int Municipio { get; set; }

        [JsonProperty("contenido")]
        public int Contenido { get; set; }

        [JsonProperty("anexo")]
        public int Anexo { get; set; }

        [JsonProperty("asunto")]
        public string Asunto { get; set; }

        [JsonProperty("cantidad")]
        public int Cantidad { get; set; }

    }
}
