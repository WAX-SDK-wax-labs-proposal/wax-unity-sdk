
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class OfferData
    {

        /// <summary>The contract associated with the offer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("contract")]
        public string Contract { get; set; }

        /// <summary>The id of the offer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("offer_id")]
        public string OfferId { get; set; }

        /// <summary>The name of the sender of the offer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("sender_name")]
        public string SenderName { get; set; }

        /// <summary>The name of the recipient of the offer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>The memo included with the offer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>The state associated with the offer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("state")]
        public int State { get; set; }

        /// <summary>A bool wheter the sender owns the contract.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("is_sender_contract")]
        public bool IsSenderContract { get; set; }

        /// <summary>A bool wheter the recipient owns the contract.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("is_recipient_contract")]
        public bool IsRecipientContract { get; set; }

        /// <summary>The data associated with the offer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("data")]
        public object Data { get; set; }
        
        /// <summary>The block at which the offer was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_block")]
        public float CreatedAtBlock { get; set; }

        /// <summary>The time at which the offer was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_time")]
        public float CreatedAtTime { get; set; }

        /// <summary>The block at which the offer was updated.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("updated_at_block")]
        public float UpdatedAtBlock { get; set; }

        /// <summary>The time at which the offer was updated.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("updated_at_time")]
        public float UpdatedAtTime { get; set; }

        /// <summary>The array of assets being sent by the sender.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("sender_assets")]
        public AssetData[] SenderAssets { get; set; }

        /// <summary>The array of assets being sent by the recipient.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("recipient_assets")]
        public AssetData[] RecipientAssets { get; set; }

    }

}