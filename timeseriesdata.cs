using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace HelloAssetAdministrationShell
{
    public class timeseriesdata
    { 
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; } = string.Empty;
        
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}