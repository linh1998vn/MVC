using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice3.Models
{
    public class DbContext: DbContext
    {
        public DatabaseContext() : base("Practice3");

        public DbSet<Category> classes { get; set; }

        public DbSet<Product> products { get; set; }
    }
}