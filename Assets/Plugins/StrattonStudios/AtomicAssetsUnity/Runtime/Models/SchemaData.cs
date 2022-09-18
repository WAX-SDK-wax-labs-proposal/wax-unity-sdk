using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class SchemaData
    {
        
        /// <summary>The contract associated with the schema.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("contract")]
        public string Contract { get; set; }

        /// <summary>The schema name.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        /// <summary>The schema format.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("format")]
        public FormatData[] Format { get; set; }

        /// <summary>The block at which the schema was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_block")]
        public float CreatedAtBlock { get; set; }

        /// <summary>The time at which the schema was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_time")]
        public float CreatedAtTime { get; set; }

        /// <summary>The collection associated with the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("collection")]
        public CollectionData Collection { get; set; }

    }

}