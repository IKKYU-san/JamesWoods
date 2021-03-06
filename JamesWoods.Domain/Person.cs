﻿using System.ComponentModel.DataAnnotations;

namespace JamesWoods.Domain
{
    public class Person {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
