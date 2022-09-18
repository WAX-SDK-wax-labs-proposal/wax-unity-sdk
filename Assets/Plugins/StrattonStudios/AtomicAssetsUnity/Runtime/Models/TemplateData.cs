

using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class TemplateData
    {

        /// <summary>The contract name for the template</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("contract")]
        public string Contract { get; set; }

        /// <summary>The unique identifier for the template.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>The Max Supply of the template that can be created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("max_supply")]
        public string MaxSupply { get; set; }

        /// <summary>Wheter the template assets can be transfered.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("is_transferable")]
        public bool Transferable { get; set; }

        /// <summary>Wheter the template assets can be transfered.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("is_burnable")]
        public bool Burnable { get; set; }

        /// <summary>The number of assets in the template that have been created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("issued_supply")]
        public string IssuedSupply { get; set; }
        
        /// <summary>The date and time the block the template was included in was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_block")]
        public float CreatedAtBlock { get; set; }

        /// <summary>The time at which the template was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_time")]
        public float CreatedAtTime { get; set; }

        /// <summary>The immutable data stored in the template.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("immutable_data")]
        public AtomicAssetsImmutableData ImmutableData { get; set; }

        /// <summary>The assets in the template.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("assets")]
        public string Assets { get; set; }

        /// <summary>The collection data the template is apart of.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("collection")]
        public CollectionData Collection { get; set; }

        /// <summary>The schema data of the template.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("scheme")]
        public SchemaData Schema { get; set; }

    }

}