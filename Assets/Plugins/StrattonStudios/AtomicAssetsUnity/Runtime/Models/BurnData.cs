using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class BurnData
    {     

        /// <summary>The account that burned the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>The collection data for the burn.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("collections")]
        public CollectionData[] Collections { get; set; }

        /// <summary>The templates data in the burn.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("templates")]
        public TemplateData[] Templates { get; set; }

        /// <summary>The assets associated with the burn.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("assets")]
        public string Assets { get; set; }

    }

}