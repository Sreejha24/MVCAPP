using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public  int PersonId { get; set; }
        public Person person { get; set; }
    }
}
