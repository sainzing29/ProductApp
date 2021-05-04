using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAPI.Models
{
    public class ModelItem
    {
        public long ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }

    }
}