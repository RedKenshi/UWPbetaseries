using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.API
{
    public  class Show
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("thetvdb_id")]
        public int TVDBId { get; set; }

        [JsonProperty("imdb_id")]
        public String IMDBId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
