using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class AtomicAssetsImmutableData
    {
        /// <summary>The image associated with the immutable data.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("img")]
        public string Image { get; set; }
        /// <summary>The name of the immutable data.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("name")]
        public string Name { get; set; }

    }

}