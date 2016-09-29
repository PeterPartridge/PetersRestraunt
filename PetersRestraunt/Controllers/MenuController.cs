using PetersRestraunt.Models;
using PetersRestraunt_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetersRestraunt.Controllers
{
    public class MenuController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        public ActionResult index(string search)
        {
            var items = _db.menusDB.OrderByDescending(c => c.menuId)
                .Where(c=>c.menuItem.Contains(search) || search == null).ToArray();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_ShowMenu", items);
            }
            return View(items);
        }

        // GET: Show menu
        [HttpGet]
        public ActionResult _ShowMenu()
        { 
            return View();
        }

        [HttpGet]
        public ActionResult BookATable()
        {
            var tables = _db.restrauntTablesDB.OrderByDescending(x => x.tableName).ToArray();

            return View(tables);
        }

        [HttpPost]
        public ActionResult BookATable(BookTableViewModel tvm, bookTable table)
        {
              try
                {
                    if (ModelState.IsValid)
                    {

                        
                    
                    }
                }
              catch (DataException)
              {
                  ModelState.AddModelError("", "An error has occured saving your reservation");
              }


                return View();
            }
        

    }
}