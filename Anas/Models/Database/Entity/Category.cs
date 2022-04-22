using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anas.Models.Database.Entity
{
    public class Category
    {

        public int id { set; get; }
        
        public string type { set; get; }

        public List<Animals> animal { set; get; }



      
    }
}