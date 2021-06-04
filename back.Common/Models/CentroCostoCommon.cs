namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class CentroCostoCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("activo")]
        public bool? Activo { get; set; }



    }
}
