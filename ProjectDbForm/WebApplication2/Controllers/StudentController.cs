using DatabaseLib3;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        // Student Create API

        [HttpPost]
        async public Task<ObjectResult> Post([FromBody] StudentDTO student)
        {
            DatabaseManager dm = new DatabaseManager();
           
            dm.insertStudent(student);

            return Created("Student Created" , student);

        }



        [HttpGet]
        async public ValueTask<StudentDTO> Get(int id)
        {
            DatabaseManager dm = new DatabaseManager();

           StudentDTO sd =    dm.FindStudent(id);

           return sd;

        }

        //Student Edit API

        [HttpPost ("StudentEdit")]
        async public Task<ObjectResult> StudentEdit ([FromBody] StudentDTO student)
        {
            DatabaseManager dm = new DatabaseManager();

            dm.deleteStudent(student);

            return Created("Student Edit", student);

        }

        //Student Delete API

        [HttpPost("StudentDelete")]
        async public Task<ObjectResult> StudentDelete([FromBody] StudentDTO student)
        {
            DatabaseManager dm = new DatabaseManager();

            dm.deleteStudent(student);

            return Created("Student Delete", student);

        }

        [HttpGet("Students")]
        async public ValueTask<List<StudentDTO>> GetStudents ()
        {
            DatabaseManager dm = new DatabaseManager();

            return dm.GetStudents();

        }
    }
}
