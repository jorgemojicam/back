namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class RegionalCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

    }
}
