using Anas.Models.Database.Context;
using Anas.Models.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Anas.Models;
using System.Data;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Anas.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: Animals

        
        public ActionResult Animals()
        {
            Context con = new Context();
            collectdata obj = new collectdata();
            List<Category> licat = new List<Category>();
           

            var data = from animals in con.animals
            join category in con.category
             on animals.category_id equals category.id
         group new {animals, category} by new {category.type} into g
         select new 
         {
              g.Key.type,
              
              Count = g.Select(x=>x.animals.id).Count()
         };
              
            foreach(var alldata in data)
            {
                Category car=new Category();
                car.id = (alldata.Count);
                car.type = alldata.type;
                licat.Add(car); 
            }
            obj._category = licat ;
           
            return View("Animals",obj);

        }


        [HttpGet]
        public JsonResult animals_Type()
        {
            Context con = new Context();

            List<Animals> name = new List<Animals>();

            var data = from animals in con.animals
                       join category in con.category
                        on animals.category_id equals category.id
                       select new { animals.id, animals.name, category.type };

            foreach (var alldata in data)
            {
                Animals n = new Animals();
                Category c = new Category();
                n.id = alldata.id;
                n.name = alldata.name;
                n.description = alldata.type;
                name.Add(n);
            }

            return Json( name ,JsonRequestBehavior.AllowGet ); 
           
        }

       
        [HttpGet]
        public JsonResult Description(int id)
        {
            Context con = new Context();
            collectdata obj = new collectdata();

            List<Animals> name = new List<Animals>();
            
            var data = from animals1 in con.animals
                       where animals1.id == id
                       select new { animals1.description };

            foreach (var alldata in data)
            {
                Animals n = new Animals();
                n.description = alldata.description;
                name.Add(n);
            }
            
            return Json(name ,JsonRequestBehavior.AllowGet);
        }
      
        
     }
}