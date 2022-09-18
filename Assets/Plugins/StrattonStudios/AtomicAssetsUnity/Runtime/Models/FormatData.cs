using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class FormatData
    {
        /// <summary>The name of the formatting.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>The type of the format.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("type")]
        public string Type { get; set; }

    }

}