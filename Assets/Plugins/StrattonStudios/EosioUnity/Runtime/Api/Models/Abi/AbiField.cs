using System;
using Newtonsoft.Json;

namespace StrattonStudios.EosioUnity.Models
{

    [Serializable]
    public struct AbiField
    {
        public AbiField(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        
        [JsonProperty("type")]
        public string Type { get; set; }
    }

}