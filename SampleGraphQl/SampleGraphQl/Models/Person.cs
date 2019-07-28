using System;
using System.Collections.Generic;

namespace SampleGraphQl.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? Price { get; set; }
        public string Manager { get; set; }
        public int? Salary { get; set; }
    }
}
