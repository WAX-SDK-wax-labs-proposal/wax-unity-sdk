using System;
using System.Collections.Generic;

namespace StrattonStudios.EosioUnity.Models
{

    [Serializable]
    public class GetTableRowsResponse : GetTableRowsResponse<object>
    {
    }

    [Serializable]
    public class GetTableRowsResponse<TRowType>
    {

        public List<TRowType> rows;

        public bool more;
    }

}