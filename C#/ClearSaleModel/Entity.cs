using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ClearSaleModel
{

    public class OffLineEntities
    {
        public List<Entity> Entities;
    }

    public class Entity
    {

        public int Id;
        public string ApiKey;
        public string ClientId;
        public string ClientSecret;
    }




}