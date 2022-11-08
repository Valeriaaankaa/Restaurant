﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Person : BaseEntity
    {        
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDay { get; set; }
        public string PhoneNumber { get; set; }
    }
}
