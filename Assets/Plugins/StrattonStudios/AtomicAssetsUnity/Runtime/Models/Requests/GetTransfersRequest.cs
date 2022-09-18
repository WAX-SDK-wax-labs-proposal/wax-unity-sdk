
using System.Collections.Generic;
using StrattonStudios.Networking.Http.Query;


namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public class GetTransfersRequest
    {
        /// <summary>The account associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("account")]
        public string Account { get; set; }
        /// <summary>The sender associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sender")]
        public string Sender { get; set; }
        /// <summary>The recipient associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("recipient")]
        public string Recipient { get; set; }
        /// <summary>The assetId associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("asset_id")]
        public string AssetId { get; set; }
        /// <summary>The templateId associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("template_id")]
        public string TemplateId { get; set; }
        /// <summary>The schema name with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("schema_name")]
        public string SchemaName { get; set; }
        /// <summary>The collection name associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_name")]
        public string CollectionName { get; set; }
        /// <summary>The blacklisted collections associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_black_list")]
        public List<string> CollectionBlacklist { get; set; }
        /// <summary>The whitelisted collections associated with the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_whitelist")]
        public List<string> CollectionWhitelist { get; set; }
        /// <summary>The page of the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("page")]
        public int? Page { get; set; }
        /// <summary>The limit of the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("limit")]
        public int? Limit { get; set; }
        /// <summary>The order of the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("order")]
        public OrderMode? Order { get; set; }
        /// <summary>The sorting order of the transfer.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sort")]
        public string Sort { get; set; }

    }

}