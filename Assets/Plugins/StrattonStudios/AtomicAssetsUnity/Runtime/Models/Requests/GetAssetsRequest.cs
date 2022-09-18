using System.Collections.Generic;
using StrattonStudios.Networking.Http.Query;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class GetAssetsRequest
    {
        /// <summary>The owner data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("owner")]
        public string Owner { get; set; }
        /// <summary>The collection name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_name")]
        public string CollectionName{ get; set; }
        /// <summary>The schema name associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("schema_name")]
        public string SchemaName { get; set; }
        /// <summary>The template id data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("template_id")]
        public int? TemplateId { get; set; }
        /// <summary>The match data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("match")]
        public string Match { get; set; }
        /// <summary>The collection blacklist associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_blacklist")]
        public List<string> CollectionBlacklist { get; set; }
        /// <summary>The collection whitelist associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("collection_whitelist")]
        public List<string> CollectionWhitelist { get; set; }
        /// <summary>The duplicate templates associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("only_duplicate_templates")]
        public bool? OnlyDuplicateTemplates { get; set; }
        /// <summary>The authorized accounts associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("authorized_account")]
        public string AuthorizedAccount { get; set; }
        /// <summary>A bool whether the offer should be hidden associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("hide_offers")]
        public bool? HideOffers { get; set; }
        /// <summary>The Id data associated with the request.</summary>
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
        public OrderMode? Order { get; set; }
        /// <summary>The sort data associated with the request.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: HttpQueryParameter("sort")]
        public string Sort { get; set; }

    }

}