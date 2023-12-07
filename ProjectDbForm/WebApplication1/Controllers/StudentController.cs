using DatabaseLib3;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Policy;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = "";
            return View("StudentCreate");
        }

        [HttpPost]
        public async Task<IActionResult> StudentCreate(StudentModel student)
        {
            DatabaseManager dm = new DatabaseManager();
            StudentDTO sd = new StudentDTO();
            sd.Id = student.Id;
            sd.Name = student.Name;
            sd.Age = student.Age;
            dm.insertStudent(sd);
            ViewBag.message = "Successfully Inserted";
            return View("StudentCreate");
        }



        [HttpPost]
        public async Task<IActionResult> StudentAPICreate(StudentModel student)
        {
            try
            {
                HttpResponseMessage obj = new HttpResponseMessage();

                StudentDTO sd = new StudentDTO();
                sd.Id = student.Id;
                sd.Name = student.Name;
                sd.Age = student.Age;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7011");

                    await client.PostAsJsonAsync<StudentDTO>("/api/Student", sd).ContinueWith(x =>
                    {
                        if (x.IsCompletedSuccessfully)
                        {
                            obj = x.Result;
                        }
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            ViewBag.message = "Successfully Inserted";
            return View("StudentCreate");
        }

        //Student Edit Section
        [HttpPost]
        public async Task<IActionResult> StudentEdit(StudentModel student)
        {
            DatabaseManager dm = new DatabaseManager();
            StudentDTO sd = new StudentDTO();
            sd.Id = student.Id;
            sd.Name = student.Name;
            sd.Age = student.Age;
            dm.insertStudent(sd);

            return View("StudentEdit");
        }
        [HttpPost]
        public async Task<IActionResult> StudentAPIEdit(StudentModel student)
        {
            try
            {
                HttpResponseMessage obj = new HttpResponseMessage();

                StudentDTO sd = new StudentDTO();
                sd.Id = student.Id;
                sd.Name = student.Name;
                sd.Age = student.Age;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7011");

                    await client.PostAsJsonAsync<StudentDTO>("/api/StudentEdit", sd).ContinueWith(x =>
                    {
                        if (x.IsCompletedSuccessfully)
                        {
                            obj = x.Result;
                        }
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View("StudentEdit");
        }

        //Student Delete Section
        [HttpPost]
        public async Task<IActionResult> StudentDelete(StudentModel student)
        {
            DatabaseManager dm = new DatabaseManager();
            StudentDTO sd = new StudentDTO();
            sd.Id = student.Id;
            sd.Name = student.Name;
            sd.Age = student.Age;
            dm.insertStudent(sd);

            return View("StudentDelete");
        }
        [HttpPost]
        public async Task<IActionResult> StudentAPIDelete(StudentModel student)
        {
            try
            {
                HttpResponseMessage obj = new HttpResponseMessage();

                StudentDTO sd = new StudentDTO();
                sd.Id = student.Id;
                sd.Name = student.Name;
                sd.Age = student.Age;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7011");

                    await client.PostAsJsonAsync<StudentDTO>("/api/Student", sd).ContinueWith(x =>
                    {
                        if (x.IsCompletedSuccessfully)
                        {
                            obj = x.Result;
                        }
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View("StudentDelete");
        }
       
       
    }
}