
using System.Collections.Generic;
using StrattonStudios.Networking.Http.Query;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class GetTemplatesRequest
    {
        /// <summary>The collection name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_name")]
        public string CollectionName { get; set; }
        /// <summary>The schema name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("schema_name")]
        public string SchemaName { get; set; }
        /// <summary>The issued supply associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("issued_supply")]
        public int? IssuedSupply { get; set; }
        /// <summary>The minimum issued supply associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("min_issued_supply")]
        public int? MinIssuedSupply { get; set; }
        /// <summary>The maximum issued supply associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("max_issued_supply")]
        public int? MaxIssuedSupply { get; set; }
        /// <summary>The assets associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("has_assets")]
        public bool? HasAssets { get; set; }
        /// <summary>The max supply associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("max_supply")]
        public int? MaxSupply { get; set; }
        /// <summary>A bool wheter the template associated with the request is burnable.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("is_burnable")]
        public bool? IsBurnable { get; set; }
        /// <summary>A bool wheter the template associated with the request is transferable.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("is_transferable")]
        public bool? IsTransferable { get; set; }
        /// <summary>The authorized account associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("authorized_account")]
        public string AuthorizedAccount { get; set; }
        /// <summary>A string related to the match in the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("match")]
        public string Match { get; set; }
        /// <summary>The blacklisted collections of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_blacklist")]
        public List<string> CollectionBlacklist { get; set; }

        /// <summary>The whitelisted collections of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_whitelist")]
        public List<string> CollectionWhitelist { get; set; }

        /// <summary>The list of ids of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("ids")]
        public List<string> Ids { get; set; }

        /// <summary>The lower bound of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("lower_bound")]
        public string LowerBound { get; set; }

        /// <summary>The upper bound of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("upper_bound")]
        public string UpperBound { get; set; }

        /// <summary>The before data of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("before")]
        public int? Before { get; set; }

        /// <summary>The after data of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("after")]
        public int? After { get; set; }

        /// <summary>The page associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("page")]
        public int? Page { get; set; }

        /// <summary>The limit associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("limit")]
        public int? Limit { get; set; }

        /// <summary>The order associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("order")]
        public OrderMode? Order { get; set; }

        /// <summary>The sorting order of the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sort")]
        public string Sort { get; set; }

    }

}