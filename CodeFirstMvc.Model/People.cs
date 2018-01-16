using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMvc.Model.Common;

namespace CodeFirstMvc.Model
{
    public class People : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime? DateBirth { get; set; }
    }
}
