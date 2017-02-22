using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClearSaleModel
{
    public class ResponseSend
    {
        public List<OrderScoreStatus> Orders { get; set; }

        public string TransactionID { get; set; }
    }
}