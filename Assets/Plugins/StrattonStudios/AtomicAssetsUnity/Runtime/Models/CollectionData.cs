
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public  class CollectionData
    {
        /// <summary>The contract of the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("contract")]
        public string Contract { get; set; }

        /// <summary>The collection name.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("collection_name")]
        public string CollectionName { get; set; }

        /// <summary>The name of the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>The image of the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("img")]
        public string Image { get; set; }

        /// <summary>The author of the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>A bool whether a notification is allowed.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("allow_notify")]
        public bool AllowNotify { get; set; }

        /// <summary>The authorized accounts for the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("authorized_accounts")]
        public string[] AuthorizedAccounts { get; set; }

        /// <summary>The accounts to notify for the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("notify_accounts")]
        public string[] NotifyAccounts { get; set; }

        /// <summary>The market fee for the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("market_fee")]
        public float MarketFee { get; set; }

        /// <summary>The data associated with the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("data")]
        public object Data { get; set; }
        /// <summary>The assets associated with the collection.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("assets")]
        public string Assets { get; set; }
        /// <summary>The block assocaited with the collection creation.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_block")]
        public float CreatedAtBlock { get; set; }
        /// <summary>The time at which the collection was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_time")]
        public float CreatedAtTime { get; set; }

    }

}