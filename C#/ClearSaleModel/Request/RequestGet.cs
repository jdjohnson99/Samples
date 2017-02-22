using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClearSaleModel.Request
{
    public class RequestGet
    {

        public string ApiKey { get; set; }

        public string LoginToken { get; set; }

        public List<string> Orders { get; set; }

        public string AnalysisLocation { get; set; }
    }
}