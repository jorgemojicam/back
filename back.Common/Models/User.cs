using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace back.Common.Models
{
    public class User
    {
        [JsonProperty("firstName")]
        public string FirtsName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
