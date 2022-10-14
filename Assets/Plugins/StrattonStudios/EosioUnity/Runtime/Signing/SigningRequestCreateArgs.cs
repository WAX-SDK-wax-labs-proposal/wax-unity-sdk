using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace StrattonStudios.EosioUnity.Signing
{

    public class SigningRequestCreateArgs : SigningRequestCommonArgs
    {

        #region Properties

        /// <summary>
        /// Single action to create request with.
        /// </summary>
        public Action Action { get; set; }

        /// <summary>
        /// Multiple actions to create request with.
        /// </summary>
        public Actions Actions { get; set; }

        /// <summary>
        /// Full or partial transaction to create request with.
        /// </summary>
        /// <remarks>
        /// If TAPoS info is omitted it will be filled in when resolving the request.
        /// </remarks>
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Create an identity request.
        /// </summary>
        /// <remarks>
        /// This uses Protocol Version 2
        /// </remarks>
        public IdentityV2 IdentityV2 { get; set; }

        /// <summary>
        /// Create an identity request. (to be implemented for protocol version 3)
        /// </summary>
        /// <remarks>
        /// This uses Protocol Version 3
        /// </remarks>
        //public IdentityV3 identityV3;

        /// <summary>
        /// Whether wallet should broadcast tx, defaults to true.
        /// </summary>
        public bool? Broadcast { get; set; }

        /// <summary>
        /// Optional callback URL the signer should hit after broadcasting or signing.
        /// </summary>
        public LinkCallback Callback { get; set; }

        #endregion

    }

}