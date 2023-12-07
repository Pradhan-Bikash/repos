using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return Redirect("https://google.com");
        }
        public ActionResult FirstAction()
        {
            return View();
        }
        public ActionResult GotoProduct()
        {
			// return RedirectToAction("Product/AddProduct");
			//return RedirectToAction("Index");
			 return RedirectToAction("AddProduct","Product");
		}
        public ActionResult GotoUpdateProduct()
        {
            return RedirectToAction("UpdateProduct","product", new {ID=20,Name="Bikash"});
        }
	}
}