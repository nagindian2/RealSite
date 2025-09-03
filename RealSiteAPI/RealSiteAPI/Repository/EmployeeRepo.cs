using RealSite.DBProvider;
using RealSite.DBProvider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSiteAPI.Repository
{
    internal class EmployeeRepo : IEmployee
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Employee addEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee deleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _appDbContext.employee_list.ToList(); //.employee_list.
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee updateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
