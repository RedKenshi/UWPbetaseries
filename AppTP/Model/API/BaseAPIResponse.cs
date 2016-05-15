using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.API
{
    public abstract class BaseAPIResponse
    {
        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }
}
