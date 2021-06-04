namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class EnviosCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("fechaEnvios")]
        public DateTime FechaEnvios { get; set; }

        [JsonProperty("centrocostoid")]
        public int CentroCostoId { get; set; }


    }
}
