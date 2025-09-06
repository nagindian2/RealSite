using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSite.DBProvider.Model
{
    public class Employee
    {
        [Required (ErrorMessage =" Id should not be empty")]
        public int id { get; set; }
        
        [MaxLength (200, ErrorMessage = " Employee name should be not more than 200 char length")]
            public string? employee_name { get; set; }
        public string? employee_phone { get; set; }
        public string? employee_email { get; set; }
        public string? employee_password { get; set; }
        public string? verification_code { get; set; }
    }
}
