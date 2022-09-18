using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;

using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class BackedTokensData
    {
        /// <summary>The token contract of the backed token.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("token_contract")]
        public string TokenContract { get; set; }
        /// <summary>The symbol of the backed token.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("token_symbol")]
        public string TokenSymbol { get; set; }
        /// <summary>The decimal precision of the token.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("token_precision")]
        public int TokenPrecision { get; set; }
        /// <summary>The amount of the backed token.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("amount")]
        public string Amount { get; set; }

    }

}