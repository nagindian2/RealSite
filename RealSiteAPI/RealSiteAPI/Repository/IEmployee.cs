using RealSite.DBProvider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSiteAPI.Repository
{
    internal interface IEmployee
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAll();
        Employee addEmployee(Employee employee);
        Employee updateEmployee(Employee employee);
        Employee deleteEmployee(int id);

    }
}
