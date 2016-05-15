using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.API
{
    public class ShowResponse : BaseAPIResponse
    {
        [JsonProperty("show")]
        public Show Show { get; set; }
    }
}
