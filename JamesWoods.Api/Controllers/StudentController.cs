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

        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateStudent(Student student)
        {
            if (student != null)
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.Created, $"{student.FirstName} är skapad");
                    //allStudents.Add(student); Eller nåt om du inte hade använt IEnumerable
                }
            }
            return BadRequest("Felaktig inmatning");
        }

        [Route("{StudentId:int}")]
        [HttpPut, HttpPatch]
        public IHttpActionResult UpdateStudent(int studentId, Student _student)
        {
            var oneStudent = allStudents.Where(student => student.Id == studentId).FirstOrDefault();
            if (_student != null && oneStudent != null)
            {
                if (ModelState.IsValid)
                {
                    if (_student.FirstName == "Stewie")
                    {
                        return Content(HttpStatusCode.Forbidden, $"{_student.FirstName} får inte uppdateras!");
                    }

                    oneStudent.FirstName = _student.FirstName;
                    oneStudent.LastName = _student.LastName;
                    oneStudent.Email = _student.Email;
                    oneStudent.Address = _student.Address;
                    oneStudent.AttendToCourses = _student.AttendToCourses;
                    return Content(HttpStatusCode.Created, $"{_student.FirstName} är uppdaterad!");
                }
            }
            return BadRequest("Felaktig uppdatering");
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
            // Delete student
            return Content(HttpStatusCode.OK, "Studenten borttagen!");
        }
    }
}
