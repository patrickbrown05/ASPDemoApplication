using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class personModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; } = 0;
        public bool isAlive { get; set; } = true;
    }
}