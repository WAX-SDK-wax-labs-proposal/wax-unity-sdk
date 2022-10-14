using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace StrattonStudios.EosioUnity.Signing
{

    public class SigningRequestEncodingOptions
    {

        /// <summary>
        /// Gets or sets the zlib, if provided the request will be compressed when encoding. (Optional)
        /// </summary>
        public IZlibProvider Zlib { get; set; }

        /// <summary>
        /// Gets or sets the Abi provider, required if the arguments contain un-encoded actions.
        /// </summary>
        public IAbiProvider AbiProvider { get; set; }

        /// <summary>
        /// Optional signature provider, will be used to create a request signature if provided.
        /// </summary>
        public ISignatureProvider SignatureProvider { get; set; }

    }

}