using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StrattonStudios.Networking.Http.Query;

namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public enum OrderMode
    {
        /// <summary>Enumeration of the order of the assets.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [HttpQueryParameter("asc")]
        Ascending,
        [HttpQueryParameter("desc")]
        Descending,

    }

}