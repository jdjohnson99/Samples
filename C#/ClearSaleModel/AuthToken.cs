using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClearSaleModel
{
    public class AuthToken
    {
        public string Value { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}