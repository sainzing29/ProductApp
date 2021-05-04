using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductAPI.Models
{
    public class ModelCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> ParentCategoryID { get; set; }
    }
}