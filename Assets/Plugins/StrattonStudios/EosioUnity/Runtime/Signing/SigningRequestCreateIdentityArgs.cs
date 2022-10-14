using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace StrattonStudios.EosioUnity.Signing
{

    public class SigningRequestCreateIdentityArgs : SigningRequestCommonArgs
    {

        /// <summary>
        /// Gets or sets the callback where the identity should be delivered.
        /// </summary>
        public LinkCallback Callback { get; set; }

        /// <summary>
        /// Gets or sets the requested account name of identity.
        /// </summary>
        /// <remarks>
        /// Defaults to placeholder (any identity) if omitted.
        /// </remarks>
        public AccountName Account { get; set; }

        /// <summary>
        /// Gets or sets the requested account permission.
        /// </summary>
        /// <remarks>
        /// Defaults to placeholder (any permission) if omitted.
        /// </remarks>
        public PermissionName Permission { get; set; }

        /// <summary>
        /// Scope for the request. (to be implemented for protocol version 3)
        /// </summary>
        //public string scope;

    }

}