using System.Collections;
using System.Collections.Generic;

using Cysharp.Threading.Tasks;

using StrattonStudios.EosioUnity;
using StrattonStudios.EosioUnity.Models;
using StrattonStudios.EosioUnity.Serialization;
using StrattonStudios.EosioUnity.Utilities;

using UnityEngine;

namespace StrattonStudios.EosioUnity.Signing
{

    public static class SigningRequestFactory
    {

        #region Public Methods

        /// <summary>
        /// Create a new signing request.
        /// </summary>
        /// <param name="args">The signing request arguments</param>
        /// <param name="options">The signing request options</param>
        /// <returns>Returns the signing request</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static async UniTask<SigningRequest> Create(SigningRequestCreateArgs args, SigningRequestEncodingOptions options)
        {
            List<Action> actions = new List<Action>();
            if (args.Action != null)
            {
                actions.Add(args.Action);
            }
            else if (args.Actions != null)
            {
                actions.AddRange(args.Actions.GetActions());
            }
            else if (args.Transaction != null)
            {
                actions.AddRange(args.Transaction.Actions);
            }
            actions = actions.FindAll(action =>
            {
                return !action.Data.IsPacked();
            });
            var accounts = actions.ConvertAll(action =>
            {
                return action.Account.Value;
            });
            var abis = new Dictionary<string, Abi>();
            if (accounts.Count != 0)
            {
                var provider = options.AbiProvider;
                if (provider == null)
                {
                    throw new System.ArgumentNullException("Missing ABI provider");
                }
                for (int i = 0; i < accounts.Count; i++)
                {
                    abis[accounts[i]] = await provider.GetAbi(accounts[i]);
                }
            }
            return await Create(args, options, abis);
        }

        /// <summary>
        /// Synchronously create a new signing request.
        /// </summary>
        /// <remarks>
        /// Throws error If an un-encoded action with no ABI definition is encountered.
        /// </remarks>
        /// <param name="args">The signing request arguments</param>
        /// <param name="options">The signing request options</param>
        /// <param name="abis">The ABIs mapping</param>
        /// <returns>Returns the signing request</returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public static async UniTask<SigningRequest> Create(SigningRequestCreateArgs args, SigningRequestEncodingOptions options, Dictionary<string, Abi> abis)
        {
            bool isIdentity = false;
            IESRRequest requestData;
            int version = 2;
            System.Action<Action> encode = (action) =>
            {
                if (action.Data.IsPacked())
                {
                    return;
                }
                var serializer = new AbiTypeWriter(null);
                action.Data.SetData(HexUtility.ToHexString(serializer.PackActionData(action, abis[action.Account.Value])));
            };

            // TODO: Implement multi-chain requests

            // The multi-chain requests require version 3 as it is not yet supported
            if (args.ChainId == null)
            {
                version = 3;
                throw new System.NotImplementedException("The protocol version 3 is not implemented");
            }

            // Set the request data
            //if (args.identityV3 != null)
            //{
            //    version = 3;
            //    requestData = args.identityV3;
            //    isIdentity = true;
            //}
            //else 
            if (args.IdentityV2 != null)
            {
                if (version == 3)
                {
                    throw new System.InvalidOperationException("Cannot use protocol version 3 with " + nameof(IdentityV2));
                }
                requestData = args.IdentityV2;
                isIdentity = true;
            }
            else if (args.Action != null && args.Actions == null && args.Transaction == null)
            {
                requestData = args.Action;
            }
            else if (args.Actions != null && args.Action == null && args.Transaction == null)
            {
                if (args.Actions.GetActions().Count == 1)
                {
                    requestData = args.Actions.GetActions()[0];
                }
                else
                {
                    requestData = args.Actions;
                }
            }
            else if (args.Transaction != null && args.Action == null && args.Actions == null)
            {
                var tx = args.Transaction;

                // Set the default values of the transaction if they're missing
                if (string.IsNullOrEmpty(tx.Expiration))
                {
                    tx.Expiration = TransactionHeader.DEFAULT_EXPIRATION;
                }
                if (tx.RefBlockNum == null || !tx.RefBlockNum.HasValue)
                {
                    tx.RefBlockNum = 0;
                }
                if (tx.RefBlockPrefix == null || !tx.RefBlockPrefix.HasValue)
                {
                    tx.RefBlockPrefix = 0;
                }
                if (tx.ContextFreeActions == null)
                {
                    tx.ContextFreeActions = new List<Action>();
                }
                if (tx.TransactionExtensions == null)
                {
                    tx.TransactionExtensions = new List<Extension>();
                }
                if (tx.DelaySec == null || !tx.DelaySec.HasValue)
                {
                    tx.DelaySec = 0;
                }
                if (tx.MaxNetUsageMs == null || !tx.MaxNetUsageMs.HasValue)
                {
                    tx.MaxNetUsageMs = 0;
                }
                if (tx.MaxNetUsageWords == null || !tx.MaxNetUsageWords.HasValue)
                {
                    tx.MaxNetUsageWords = 0;
                }
                if (tx.Actions == null)
                {
                    tx.Actions = new List<Action>();
                }

                // Iterate through actions and encode as needed
                tx.Actions.ForEach(encode);
                requestData = tx;
            }
            else
            {
                throw new System.ArgumentException("Invalid arguments: Must have exactly one of action, actions or transaction");
            }

            // Set the Chain ID for the request
            Chain chainId;
            if (args.ChainId == null)
            {

                // Use EOS if no chain is specified
                chainId = Chain.EOS;
            }
            else
            {
                chainId = args.ChainId;
            }

            // Set the request flags and callback
            var flag = RequestFlag.None;
            var callback = "";
            if (isIdentity)
            {
                flag.SetBackground(true);
            }
            if (args.Broadcast != null && args.Broadcast.HasValue)
            {
                flag.SetBroadcast(args.Broadcast.Value);
            }
            if (args.Callback != null)
            {
                callback = args.Callback.Url;
                if (args.Callback.Background != null && args.Callback.Background.HasValue)
                {
                    flag.SetBackground(args.Callback.Background.Value);
                }
            }

            // Add info pairs if there are any
            var info = new List<InfoPair>();
            if (args.info != null)
            {
                info = args.info;
            }

            // TODO: To be implemented for protocol version 3
            //if (args.chainIds != null && args.chainId == null)
            //{
            //    info.Add(InfoPair.Create(ChainId.CHAIN_IDS, JSRuntime.SerializeChains(args.chainIds.ToArray())));
            //}

            var request = new SigningRequest(options.AbiProvider, options.Zlib);
            request.SetCallback(callback);
            request.SetRequestFlag(flag);
            await request.SetRequest(requestData);
            request.SetInfoPairs(info);
            request.SetChainId(chainId.ToChainId());

            if (options.SignatureProvider != null)
            {
                request.Sign(options.SignatureProvider);
            }

            return request;
        }

        /// <summary>
        /// Creates an identity request.
        /// </summary>
        /// <param name="args">The identity request arguments</param>
        /// <param name="options">The signing request options</param>
        /// <returns>Returns the signing request for identity</returns>
        public static UniTask<SigningRequest> Identity(SigningRequestCreateIdentityArgs args, SigningRequestEncodingOptions options)
        {
            var createArgs = new SigningRequestCreateArgs();
            createArgs.info = args.info;

            // TODO: To be implemented for protocol version 3
            //createArgs.chainIds = args.chainIds;
            //createArgs.ChainId = args.ChainId;
            createArgs.ChainType = args.ChainType;
            createArgs.Callback = args.Callback;
            createArgs.Broadcast = false;
            PermissionLevel permission = new PermissionLevel(
                args.Account.Value ?? SigningRequest.PLACEHOLDER_NAME,
                args.Permission.Value ?? SigningRequest.PLACEHOLDER_PERMISSION);

            // TODO: To be implemented for protocol version 3
            //if (!string.IsNullOrEmpty(args.scope))
            //{
            //    var permission = new PermissionLevel(args.account, args.permission);
            //    createArgs.identityV3 = new IdentityV3(args.scope, permission);
            //}
            //else
            //{
            if (permission.Actor.Value == SigningRequest.PLACEHOLDER_NAME && permission.Permission.Value == SigningRequest.PLACEHOLDER_PERMISSION)
            {
                permission = null;
            }
            createArgs.IdentityV2 = new IdentityV2(permission);
            //}
            return Create(createArgs, options, null);
        }

        /// <summary>
        /// Creates a signing request from serialized transaction's data.
        /// </summary>
        /// <param name="chainId">The chain's id</param>
        /// <param name="serializedTransaction">The serialized transaction data</param>
        /// <param name="options">The signing request options</param>
        /// <returns>Returns the signing request for transaction</returns>
        public static SigningRequest CreateFromTransaction(ChainId chainId, byte[] serializedTransaction, SigningRequestEncodingOptions options)
        {
            // Layout
            // 1. Protocol version
            // 2. Chain's ID or Alias
            // 3. Transaction Variant ID
            // 4. Transaction Data
            // 5. Callback
            // 6. Info pairs

            // Create a basic signing request in binary format just using the transaction's serialized data
            using var ms = new System.IO.MemoryStream();

            // The signing request protocol version
            ms.WriteByte(2);

            // The chain's id or alias is serialized depending on the variant's first value
            var id = chainId.ToVariant();
            string chainType = (string)id[0];

            bool WriteChainId()
            {

                // Set the chain's type as id
                ms.WriteByte(1);

                // Serialize the chain's id
                byte[] bytes = HexUtility.FromHexString((string)id[1]);
                ms.Write(bytes, 0, bytes.Length);
                return true;
            }

            bool WriteChainAlias()
            {

                // Set the chain's type as alias
                ms.WriteByte(0);

                // Serialize the chain's alias
                ms.WriteByte(System.Convert.ToByte((int)id[1]));
                return true;
            }

            // Ensure the right chain type information is written
            bool chainInfoWritten = chainType == "chain_alias" ? WriteChainAlias() : WriteChainId();

            // The transaction variant id
            ms.WriteByte(2);

            // The transaction's serialized data gets inserted in to the signing request
            ms.Write(serializedTransaction, 0, serializedTransaction.Length);

            // The signing request flags
            ms.WriteByte((byte)RequestFlag.Broadcast);

            // The request callback is ignored and is set as unspecified as it is not provided
            ms.WriteByte(0);

            // The info pairs are ignored
            ms.WriteByte(0);

            var msArray = ms.ToArray();
            return CreateFromBinaryData(msArray, options);
        }

        /// <summary>
        /// Creates a signing request from encoded `esr:` URI string.
        /// </summary>
        /// <param name="uri">The ESR encoded URI string</param>
        /// <param name="options">The signing request options</param>
        /// <returns>Returns the signing request object decoded from the ESR URI</returns>
        public static SigningRequest CreateFromUri(string uri, SigningRequestEncodingOptions options)
        {
            var request = new SigningRequest(options.AbiProvider, options.Zlib);
            return request.Load(uri);
        }

        /// <summary>
        /// Creates a signing request from binary data.
        /// </summary>
        /// <param name="data">The binary data</param>
        /// <param name="options">The signing request options</param>
        /// <returns>Returns the signing request object</returns>
        public static SigningRequest CreateFromBinaryData(byte[] data, SigningRequestEncodingOptions options)
        {
            var request = new SigningRequest(options.AbiProvider, options.Zlib);
            return request.Load(data);
        }

        #endregion

    }

}