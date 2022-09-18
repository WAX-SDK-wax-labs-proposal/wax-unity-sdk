
using System.Collections.Generic;
using StrattonStudios.Networking.Http.Query;


namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class GetOffersRequest
    {
        /// <summary>The account associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("account")]
        public string Account { get; set; }
        /// <summary>The sender associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sender")]
        public string Sender { get; set; }
        /// <summary>The recipient associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("recipient")]
        public string Recipient { get; set; }
        /// <summary>The state associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("state")]
        public string State { get; set; }
        /// <summary>A bool wheter the recipent is a contract associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("is_recipient_contract")]
        public bool? IsRecipientContract { get; set; }
        /// <summary>The asset id assocaited with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("asset_Id")]
        public string AssetId { get; set; }
        /// <summary>The template id associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("template_name")]
        public string TemplateId { get; set; }
        /// <summary>The schema name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("schema_name")]
        public string SchemaName { get; set; }
        /// <summary>The collection name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_name")]
        public string CollectionName { get; set; }
        /// <summary>The account for the whitelist with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("account_whitelist")]
        public string AccountWhitelist { get; set; }
        /// <summary>The account for the blacklist with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("account_blacklist")]
        public string AccountBlacklist { get; set; }
        /// <summary>The sender asset for the whitelist with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sender_asset_whitelist")]
        public string SenderAssetWhitelist { get; set; }
        /// <summary>The sender asset for the blacklist with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sender_asset_blacklist")]
        public string SenderAssetBlacklist { get; set; }
        /// <summary>The recipient asset for the whitelist with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("recipient_asset_whitelist")]
        public string RecipientAssetWhitelist { get; set; }
        /// <summary>The recipient asset for the blacklist with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("recipient_asset_blacklist")]
        public string RecipientAssetBlacklist { get; set; }
        /// <summary>The collection blacklist assocaited with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_blacklist")]
        public List<string> CollectionBlacklist { get; set; }
        /// <summary>The collection whitelist associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_whitelist")]
        public List<string> CollectionWhitelist { get; set; }
        /// <summary>The ids associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("ids")]
        public List<string> Ids { get; set; }
        /// <summary>The lower bound associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("account")]
        public string LowerBound { get; set; }
        /// <summary>The upper bound associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("upper_bound")]
        public string UpperBound { get; set; }
        /// <summary>The before data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("before")]
        public int? efore { get; set; }
        /// <summary>The after data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("after")]
        public int? After { get; set; }
        /// <summary>The page number associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("page")]
        public int? Page { get; set; }
        /// <summary>The limit associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("limit")]
        public int? Limit { get; set; }
        /// <summary>The sort order associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("order")]
        public OrderMode? Order { get; set; }
        /// <summary>The sort field associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sort")]
        public string Sort { get; set; }

    }

}