using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Anas.Models.Database.Entity;

namespace Anas.Models.Database.Context
{
    public class Context : DbContext
    {
        public Context() : base("Animals") { }

        public virtual DbSet<Animals> animals { set; get; }
        public virtual DbSet<Category> category { set; get; }
    }
}