﻿namespace back.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class DepartamentoCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

    }
}
