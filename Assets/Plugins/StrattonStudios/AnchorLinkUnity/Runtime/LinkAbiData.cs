using System.Collections.Generic;
using StrattonStudios.EosioUnity.Models;

namespace StrattonStudios.AnchorLinkUnity
{
    public static class LinkAbiData
    {
        public static readonly Abi Types = new Abi()
        {
            Version = "eosio::abi/1.1", Types = new List<AbiType>(),
            Structs = new List<AbiStruct>
            {
                new AbiStruct()
                {
                    name = "sealed_message", @base = "",
                    fields = new List<AbiField>()
                    {
                        new("from", "public_key"),
                        new("nonce", "uint64"),
                        new("ciphertext", "bytes"),
                        new("checksum", "uint32")
                    }
                },
                new AbiStruct()
                {
                    name = "link_create", @base = "",
                    fields = new List<AbiField>()
                    {
                        new("session_name","name"),
                        new("request_key","public_key")
                    }
                },
                new AbiStruct()
                {
                    name = "link_info", @base = "",
                    fields = new List<AbiField>()
                    {
                        new("expiration", "time_point_sec")
                    }
                }
            }
        };
    }
}