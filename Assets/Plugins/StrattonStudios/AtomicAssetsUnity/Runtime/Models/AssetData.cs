using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;



namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class AssetData
    {

        /// <summary>The contract associated with the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("contract")]
        public string Contract { get; set; }

        /// <summary>The asset ID of the NFT.</summary>
        /// <remarks>This property is only available when the page is loaded from an asset.</remarks>
        [property: JsonProperty("asset_id")]
        public string AssetID { get; set; }

        /// <summary>The owner of the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>A bool wheter the asset can be transferred.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("is_transferable")]
        public bool Transferable { get; set; }

        /// <summary>A bool wheter the asset can be burned.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("is_burnable")]
        public bool Burnable { get; set; }

        /// <summary>The collection data associated with the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("collection")]
        public CollectionData Collection { get; set; }

        /// <summary>The collection data associated with the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("schema")]
        public SchemaData Schema { get; set; }

        /// <summary>The template data associated with the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("template")]
        public TemplateData Template { get; set; }

        /// <summary>The immutable data associated with the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("mutable_data")]
        public object MutableData { get; set; }

        /// <summary>The immutable data associated with the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("immutable_data")]
        public object ImmutableData { get; set; }

        /// <summary>The template mint number associated with the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("template_mint")]
        public string TemplateMint { get; set; }

        /// <summary>Wheter the token is backed by any tokens.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("backed_tokens")]
        public BackedTokensData[] BackedTokens { get; set; }

        /// <summary>The block at which the asset was updated.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("updated_at_block")]
        public string UpdatedAtBlock { get; set; }

        /// <summary>The time at which the asset was updated.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("updated_at_time")]
        public string UpdatedAtTime { get; set; }

        /// <summary>The block at which the asset was transfered.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("transferred_at_block")]
        public string TransferredAtBlock { get; set; }

        /// <summary>The time at which the asset was transfered.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("transferred_at_time")]
        public string TransferredAtTime { get; set; }

        /// <summary>The block at which the asset was minted.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("minted_at_block")]
        public string MintedAtBlock { get; set; }

        /// <summary>The time at which the asset was minted.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("minted_at_time")]
        public string MintedAtTime { get; set; }

        /// <summary>The name of the asset.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("name")]
        public string Name { get; set; }

    }

}