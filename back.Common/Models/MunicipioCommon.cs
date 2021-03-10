namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class MunicipioCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("departamento")]
        public DepartamentoCommon Departamento { get; set; }

    }
}
