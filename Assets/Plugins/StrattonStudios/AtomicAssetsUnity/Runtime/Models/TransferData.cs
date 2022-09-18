using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class TransferData
    {
        /// <summary>Contract that owns the asset</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("contract")]
        public string Contract { get; set; }

        /// <summary>The unique identifier for the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("transfer_id")]
        public string TransferId { get; set; }

        /// <summary>The name of the sender.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("sender_name")]
        public string SenderName { get; set; }

        /// <summary>The name of the recipient.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>The Memo included with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>The assets associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("assets")]
        public AssetData[] Assets { get; set; }

        /// <summary>The date and time the block the transfer was included in was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_block")]
        public float CreatedAtBlock { get; set; }

        /// <summary>The time at which the transfer was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_time")]
        public float CreatedAtTime { get; set; }

    }

}