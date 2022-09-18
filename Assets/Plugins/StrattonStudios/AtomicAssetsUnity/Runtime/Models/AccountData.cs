using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class AccountData
    {
        /// <summary>The account associated with the user.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>

        [property: JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>The collections owned by the account.</summary>
         /// <remarks>This is a property that is serialized as a JSON property.</remarks>

        [property: JsonProperty("collections")]
        public CollectionsDataWrapper[] Collections { get; set; }

        /// <summary>The templates associated with the account.</summary>
         /// <remarks>This is a property that is serialized as a JSON property.</remarks>

        [property: JsonProperty("templates")]
        public TemplateData[] Templates { get; set; }

        /// <summary>The schemas associated with the account.</summary>
         /// <remarks>This is a property that is serialized as a JSON property.</remarks>

        [property: JsonProperty("schemas")]
        public SchemaData[] Schemas { get; set; }

        /// <summary>The assets associated with the account.</summary>
         /// <remarks>This is a property that is serialized as a JSON property.</remarks>

        [property: JsonProperty("assets")]
        public string Assets { get; set; }

        public partial class CollectionsDataWrapper
        {  
            /// <summary>The collection data.</summary>
             /// <remarks>This is a property that is serialized as a JSON property.</remarks>

            [property: JsonProperty("collection")]
            public CollectionData Collection { get; set; }

            /// <summary>The assets associated with the assets.</summary>
            /// <remarks>This is a property that is serialized as a JSON property.</remarks>

            [property: JsonProperty("assets")]
            public string Assets { get; set; }
        }

    }

}