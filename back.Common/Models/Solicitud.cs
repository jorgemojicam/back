namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class Solicitud
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("tipo")]
        public int Tipo { get; set; }

        [JsonProperty("origen")]
        public int Origen { get; set; }

        [JsonProperty("solicitante")]
        public string Solicitante { get; set; }

        [JsonProperty("fechaCreacion")]
        public DateTime? FechaCreacion { get; set; }

        [JsonProperty("fechaEnvio")]
        public DateTime? FechaEnvio { get; set; }

        [JsonProperty("centroCosto")]
        public int? CentroCosto { get; set; }

        [JsonProperty("estado")]
        public int? Estado { get; set; }

        [JsonProperty("estadoCentroCosto")]
        public int? EstadoCentroCosto { get; set; }

        [JsonProperty("guia")]
        public int? Guia { get; set; }

        [JsonProperty("modo")]
        public int? Modo { get; set; }

        [JsonProperty("unidadEmpaque")]
        public int? UnidadEmpaque { get; set; }

        [JsonProperty("precinto")]
        public int? Precinto { get; set; }

        [JsonProperty("transportadora")]
        public int? Transportadora { get; set; }

    }
}
