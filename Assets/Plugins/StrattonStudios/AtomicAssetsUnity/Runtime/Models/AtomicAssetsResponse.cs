using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class AtomicAssetsResponse<TData>
    {
        /// <summary>A bool wheter the response was succesful.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>The data assocaited with the response.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("data")]
        public TData Data { get; set; }
        /// <summary>The query of the response.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("query_time")]
        public long QueryTime { get; set; }

    }

}