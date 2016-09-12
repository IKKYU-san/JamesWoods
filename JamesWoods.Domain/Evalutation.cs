using JamesWoods.Domain.Enums;

namespace JamesWoods.Domain
{
    public class Evalutation
    {
        public int Id { get; set; }
        public Mark Mark { get; set; }
        public string Comment { get; set; }
        public Assignement Assignement { get; set; }
        public Student Student { get; set; }
    }
}
