using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Anas.Models.Database.Entity;
using System.Data.SqlClient;
using System.Data;

namespace Anas.Models
{
    public class collectdata
    {
      public  List<Animals> _animlas { set; get; }
       public List<Category> _category { set; get; }

    }
}