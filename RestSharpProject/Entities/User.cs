using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestSharpProject.Entities
{
    public class User
    {
        [JsonProperty("login")]
        public string Login { get; set; }
    }
}
