using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClearSaleModel
{
    public class FingerPrint
    {
        private string _sessionID;

         
        public string SessionID
        {
            get { return _sessionID; }
            set { _sessionID = value; }
        }

        public FingerPrint()
        {
            _sessionID = "Default-ClearSale-SessionID";
        }
    }
}