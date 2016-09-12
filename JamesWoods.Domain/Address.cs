using JamesWoods.Domain.Enums;

namespace JamesWoods.Domain
{
    public class Address
    {
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Country Country { get; set; }
    }
}
