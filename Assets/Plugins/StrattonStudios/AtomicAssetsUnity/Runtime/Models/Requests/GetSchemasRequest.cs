
using System.Collections.Generic;
using StrattonStudios.Networking.Http.Query;


namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class GetSchemasRequest
    {   
        /// <summary>The collection name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_name")]
        public string CollectionName { get; set; }
        /// <summary>The authorized associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("authorized_account")]
        public string AuthorizedAccount { get; set; }
        /// <summary>The schema name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("schema_name")]
        public string SchemaName { get; set; }
        /// <summary>The match data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("match")]
        public string Match { get; set; }
        /// <summary>The blacklisted collection associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_blacklist")]
        public List<string> CollectionBlacklist { get; set; }
        /// <summary>The whitelisted collection associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_whitelist")]
        public List<string> CollectionWhitelist { get; set; }
        /// <summary>The ids associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("ids")]
        public List<string> Ids { get; set; }
        /// <summary>The lower bound associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("lower_bound")]
        public string LowerBound { get; set; }
        /// <summary>The upper bound associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("upper_bound")]
        public string UpperBound { get; set; }
        /// <summary>The before data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("before")]
        public int? Before { get; set; }
        /// <summary>The after data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("after")]
        public int? After { get; set; }
        /// <summary>The page data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("page")]
        public int? Page { get; set; }
        /// <summary>The limit data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("limit")]
        public int? Limit { get; set; }
        /// <summary>The order data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("order")]
        public OrderMode? OrderMode { get; set; }
        /// <summary>The sort data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sort")]
        public string Sort { get; set; }

    }

}