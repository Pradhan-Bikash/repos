using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectMvc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(string title)
        {
            return View();
        }
        public ActionResult Detail(string Title, string DetailName)
        { 
            return View();
        }
    }
}