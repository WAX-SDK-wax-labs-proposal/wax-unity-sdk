using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class LogsData
    {
        /// <summary>The id of the log.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("log_id")]
        public string LogId { get; set; }

        /// <summary>The name of the log.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>The data associated with the log.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("data")]
        public object Data { get; set; }
        /// <summary>The transaction id of the log.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("txid")]
        public string TxId { get; set; }
        /// <summary>The block at which the log was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_block")]
        public string CreatedAtBlock { get; set; }
        /// <summary>The time at which the log was created.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("created_at_time")]
        public string CreatedAtTime { get; set; }

    }

}