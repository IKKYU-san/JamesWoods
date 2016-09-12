using JamesWoods.Domain;
using JamesWoods.Service.Dummy;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    }
}
