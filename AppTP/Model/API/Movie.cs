using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.API
{
    public class Movie
    {
        private int v1;
        private int v2;
        private string v3;
        private string v4;
        private string v5;

        public Movie(int v1, int v2, string v3, string v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        [JsonProperty("id")]
        public static int Id { get; set; }

        [JsonProperty("thetvdb_id")]
        public int TVDBId { get; set; }

        [JsonProperty("imdb_id")]
        public String IMDBId { get; set; }

        [JsonProperty("title")]
        public static string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
