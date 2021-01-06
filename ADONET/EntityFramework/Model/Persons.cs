using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public long Mobile { get; set; }
        public ICollection<Job> job { get; set; }
    }
}
