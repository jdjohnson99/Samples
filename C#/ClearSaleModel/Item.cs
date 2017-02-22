﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ClearSaleModel
{
    public class Item
    {       
        public string ProductId { get; set; }
       
        public string ProductTitle { get; set; }
      
        public decimal? Price { get; set; }
     
        public string Category { get; set; }
       
        public int Quantity { get; set; }
    }
}