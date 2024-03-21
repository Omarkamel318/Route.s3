using Microsoft.EntityFrameworkCore;
using Route.s3.BLL.Interfaces;
using Route.s3.DAL.Data;
using Route.s3.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.s3.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public DepartmentRepository(ApplicationDbContext dbcontext) //inject dbcontext by clr when create object from DepartmentRepository
        {
            _dbcontext = dbcontext;
        }
        public int Add(Department entity)
        {
            _dbcontext.Add(entity);

            return _dbcontext.SaveChanges();
        }

        public int Delete(Department entity)
        {
            _dbcontext.Remove(entity);
            return _dbcontext.SaveChanges();
        }
        public int Update(Department entity)
        {
            _dbcontext.Update(entity);
            return _dbcontext.SaveChanges();
        }

        public Department Get(int id)
        {
           var department = _dbcontext.Departments.Local.Where(d=>d.Id == id).FirstOrDefault();
            if(department is null)
                department = _dbcontext.Departments.Where(d=>d.Id == id).FirstOrDefault();
            return department;  
        }

        public IEnumerable<Department> GetAll() => _dbcontext.Departments.AsNoTracking().ToList();
        

    }
}