
using System.Collections.Generic;

namespace JamesWoods.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Assignement> Assignements { get; set; }
    }
}
