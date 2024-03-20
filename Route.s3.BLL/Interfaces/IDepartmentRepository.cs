using Route.s3.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.s3.BLL.Interfaces
{
    internal interface IDepartmentRepository
    {
        int Add(Department entity);

        int Update(Department entity);

        int Delete(Department entity);

        Department Get(int id);

        IEnumerable<Department> GetAll();
    }
}
