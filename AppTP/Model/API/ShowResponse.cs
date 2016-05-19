using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Datas
{
    public class ShowResponse : BaseAPIResponse
    {
        [JsonProperty("show")]
        public Serie Serie { get; set; }
    }
}
