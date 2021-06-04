namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class ColaboradoresCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("centrocostoid")]
        public int CentroCostoId { get; set; }

        [JsonProperty("rolid")]
        public int RolId { get; set; }

        [JsonProperty("celular")]
        public decimal Celular { get; set; }

    }
}
