﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMvc.Model.Common;

namespace CodeFirstMvc.Model
{
    public class Department : AuditableEntity
    {
        public string Name { get; set; }
        public Decimal Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
