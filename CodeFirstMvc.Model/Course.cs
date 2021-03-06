﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMvc.Model.Common;

namespace CodeFirstMvc.Model
{
    public class Course : AuditableEntity
    {
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
