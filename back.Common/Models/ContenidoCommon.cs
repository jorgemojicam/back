namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class ContenidoCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("valorEstimado")]
        public decimal ValorEstimado { get; set; }
        [JsonProperty("categoria")]
        public CategoriaCommon Categoria { get; set; }

    }
}
