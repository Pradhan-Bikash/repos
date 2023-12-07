using DatabaseLib3;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DisplayController : Controller
    {
        public IActionResult Index()
        {

            return View("Index");
        }
        public async Task<IActionResult> StudentAPIDisplay()
        
        {
            DisplayModel dm = new DisplayModel();
            try
            {
                HttpResponseMessage obj = new HttpResponseMessage();


              
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7011");

                    await client.GetFromJsonAsync<List<StudentDTO>>("/api/Student/Students").ContinueWith(x =>
                    {
                        if (x.IsCompletedSuccessfully)
                        {
                           dm.Students  = x.Result;
                        }
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View("Display", dm);
        }
    }
}
