using JamesWoods.Domain;
using JamesWoods.Service.Dummy;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace JamesWoods.Api.Controllers
{

    [RoutePrefix("api/student")]
    public class StudentController : ApiController
    {
        IEnumerable<Student> allStudents = MockSchool.AllStudents;
        IEnumerable<Course> allCourses = MockSchool.AllCourses;

        [HttpGet]
        [Route("")]
        public IEnumerable<Student> GetAllStudents()
        {
            return allStudents;
        }

        [HttpGet]
        [Route("{StudentId:int}")]
        public IHttpActionResult GetStudent(int studentId)
        {
            var oneStudent = allStudents.Where(student => student.Id == studentId).FirstOrDefault();

            if (oneStudent == null)
            {
                return Content(HttpStatusCode.Forbidden, "Studenten finns inte");
            }
            return Ok(oneStudent);

        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateStudent(Student student)
        {
            if (student == null)
            {
                return BadRequest("Felaktig inmatning");
            }

            if (student.FirstName == null)
            {
                return BadRequest("Felaktig inmatning, studenter måste ha ett förnamn");
            }

            //allStudents.Add(student); Eller nåt om du inte hade använt IEnumerable
            return Content(HttpStatusCode.Created, $"{student.FirstName} är skapad");
        }

        [Route("{StudentId:int}")]
        [HttpDelete]
        public IHttpActionResult DeleteStudent(int studentId)
        {
            //var status = allStudents.Where(); Linq?
            var oneStudent = allStudents.Where(student => student.Id == studentId).FirstOrDefault();
            if (oneStudent == null)
            {
                return Content(HttpStatusCode.Forbidden, "Studenten finns inte");
            }
            return Content(HttpStatusCode.OK, "Studenten borttagen!");
        }
    }
}
