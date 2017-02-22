using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ClearSaleModel.Request
{
    public class RequestSend
    {

        public string ApiKey { get; set; }

        public string LoginToken { get; set; }

        public List<Order> Orders { get; set; }

        public string AnalysisLocation { get; set; }
    }

}