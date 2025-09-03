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
            List < Employee > ee = _appDbContext.employee_list
                .Select(em => new Employee { id = em.id, employee_name = em.employee_name, employee_phone = em.employee_phone, employee_email = em.employee_email })
                .ToList(); //.employee_list.
             //     .Select(e => new { e.Column1, e.Column2, e.Column3 })

            return ee;
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
