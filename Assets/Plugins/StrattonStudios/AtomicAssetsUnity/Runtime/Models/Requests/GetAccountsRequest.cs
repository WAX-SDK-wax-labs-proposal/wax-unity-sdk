using System.Collections.Generic;
using StrattonStudios.Networking.Http.Query;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public class GetAccountsRequest
    {
        /// <summary>The match of the get account request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("match")]
        public string Match { get; set; }
        /// <summary>The collection name of the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_name")]
        public string CollectionName { get; set; }
        /// <summary>The schema name associated with the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("schema_name")]
        public string SchemaName { get; set; }
        /// <summary>The id associated with the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("template_id")]
        public string TemplateId { get; set; }
        /// <summary>A bool wheter the offer can be hidden</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("hide_offers")]
        public bool? HideOffers { get; set; }
        /// <summary>A list of blacklisted collections in the account</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collections_blacklist")]
        public List<string> CollectionBlacklist { get; set; }
        /// <summary>A list of whitelisted collections in the account</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collections_whitelist")]
        public List<string> CollectionWhitelist { get; set; }
        /// <summary>The Ids of the assets in the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("ids")]
        public string Ids { get; set; }
        /// <summary>The lower bound of the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("lower_bound")]
        public string LowerBound { get; set; }
        /// <summary>The upper bound of the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("upper_bound")]
        public string UpperBound { get; set; }
        /// <summary>The page of the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("page")]
        public int? Page { get; set; }
        /// <summary>The limit of the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("limit")]
        public int? Limit { get; set; }
        /// <summary>The order of the request</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("order")]
        public OrderMode? Order { get; set; }

    }

}