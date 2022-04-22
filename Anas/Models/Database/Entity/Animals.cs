using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Anas.Models.Database.Entity
{
    public class Animals
    {

        public int id { set; get; }

        public string name { set; get; }

        public string description { set; get; }


        //relation_one_two_many
        [ForeignKey("Category")]
        public int category_id { set; get; }
        public Category Category { set; get; }

    }
}