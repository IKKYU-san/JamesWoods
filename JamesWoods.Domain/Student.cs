
using System.Collections.Generic;

namespace JamesWoods.Domain
{
    public class Student : Person
    {
        public int? Id { get; set; }
        public List<Course> AttendToCourses { get; set; }
    }
}
