using System;
using System.Collections.Generic;
using System.Text;

namespace MyDemoProj
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int Age { get; set; }
        public PersonDetail PersonDetail { get; set; }
    }

    public class PersonDetail 
    {
        public int PersonDetailId { get; set; }
        public string Address { get; set; }
    }

}
