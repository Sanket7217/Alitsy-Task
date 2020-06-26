using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using AlitsyTask.Models;
using System.Data.SqlClient;
using System.Configuration;



namespace AlitsyTask.Controllers
{
    
    public class HomeController : Controller
    {
        ImportElectricityRepository import = new ImportElectricityRepository();
        public ActionResult Index()
        {
            return View();
        }

       

        [HttpPost]
       
        public ActionResult save(ImportElectricity objdata)
        {
            //TODO input validation missing 2
            //TODO Error handling 1
            Console.WriteLine("inside  add........................");
            return Json(import.SaveRecord(objdata));
        }


    }
}
