using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StrattonStudios.AtomicAssetsUnity.Models
{

    public partial class StatsData
    {

        /// <summary>The mint number of the template.</summary>
        /// <remarks>This is a property that is serialized as a JSON property.</remarks>
        [property: JsonProperty("template_mint")]
        public int TemplateMint { get; set; }

    }

}