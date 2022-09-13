using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice3.Models
{
    public class Category
    {
       public int CategoryId { get; set; }
       public string CategoryName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}