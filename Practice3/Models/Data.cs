using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice3.Models
{
    public class Data: DbContext
    {
        public Data() : base("DBConnection")
        {

        }

        public DbSet<Category> classes { get; set; }

        public DbSet<Product> products { get; set; }
    }
}