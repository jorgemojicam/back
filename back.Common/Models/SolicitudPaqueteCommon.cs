namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class SolicitudPaqueteCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("solicitudid")]
        public int SolicitudId { get; set; }

        [JsonProperty("paqueteid")]
        public int PaqueteId { get; set; }

        [JsonProperty("recididocad")]
        public int RecididoCad { get; set; }

        [JsonProperty("recibidooficina")]
        public int RecibidoOficina { get; set; }

        [JsonProperty("recibidosa")]
        public int RecibidoSA { get; set; }

        [JsonProperty("recibidorec")]
        public int RecibidoREC { get; set; }


    }
}
