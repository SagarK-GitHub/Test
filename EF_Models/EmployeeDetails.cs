using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models
{
    public class EmployeeDetails
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public string experience { get; set; }
        public Nullable<decimal> salary { get; set; }
        public string designation { get; set; }
        public string skillSet { get; set; }
    }
}
