using AppTP.Model.Datas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Datas
{
    public class MovieResponse : BaseAPIResponse
    {
        [JsonProperty("movie")]
        public Movie Movie { get; set; }
    }
}
