using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstMvc.Model;

namespace CodeFirstMvc.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext context) : base(context)
        {

        }
    }

    public interface IDepartmentRepository : IRepository<Department>
    {

    }
}
