using System.Collections.Generic;

using StrattonStudios.EosioUnity.Models;

namespace StrattonStudios.AnchorLinkUnity
{
    public static class LinkAbiData
    {
        public static readonly Abi Types = new Abi()
        {
            Version = "eosio::abi/1.1",
            Types = new List<AbiType>(),
            Structs = new List<AbiStruct>
            {
                new AbiStruct()
                {
                    name = "sealed_message", @base = "",
                    fields = new List<AbiField>()
                    {
                        new AbiField("from", "public_key"),
                        new AbiField("nonce", "uint64"),
                        new AbiField("ciphertext", "bytes"),
                        new AbiField("checksum", "uint32")
                    }
                },
                new AbiStruct()
                {
                    name = "link_create", @base = "",
                    fields = new List<AbiField>()
                    {
                        new AbiField("session_name","name"),
                        new AbiField("request_key","public_key")
                    }
                },
                new AbiStruct()
                {
                    name = "link_info", @base = "",
                    fields = new List<AbiField>()
                    {
                        new AbiField("expiration", "time_point_sec")
                    }
                }
            }
        };
    }
}