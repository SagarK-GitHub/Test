using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Models;

namespace EF_DataAccess
{
    public class CrudOperations
    {
        SagarEntities objSagar = new SagarEntities();
        employee objEmployee;

        public  void Add(EmployeeDetails employee)
        {
            objEmployee = new employee();
            objEmployee.empId = employee.empId;
            objEmployee.empName = employee.empName;
            objEmployee.experience = employee.experience;
            objEmployee.salary = employee.salary;
            objEmployee.skillSet = employee.skillSet;
            objEmployee.designation = employee.designation;
            objSagar.employees.Add(objEmployee);
            objSagar.SaveChanges();
        }

        public void Remove(int id)
        {
            objEmployee = objSagar.employees.SingleOrDefault(s => s.empId == id);
            objSagar.employees.Remove(objEmployee);
            objSagar.SaveChanges();
        }

        public EmployeeDetails GetDetails(int id)
        {
            objEmployee = objSagar.employees.SingleOrDefault(s => s.empId == id);
            if (objEmployee != null)
            {
                EmployeeDetails employee = new EmployeeDetails();
                employee.empId = objEmployee.empId;
                employee.empName = objEmployee.empName;
                employee.experience = objEmployee.experience;
                employee.salary = objEmployee.salary;
                employee.skillSet = objEmployee.skillSet;
                employee.designation = objEmployee.designation;
                return employee;
            }
            return null;
        }

        public void UpdateDetails(EmployeeDetails emp)
        {
            objEmployee = objSagar.employees.SingleOrDefault(s => s.empId == emp.empId);

            objEmployee.empName = emp.empName;
            objEmployee.experience = emp.experience;
            objEmployee.salary = emp.salary;
            objEmployee.skillSet = emp.skillSet;
            objEmployee.designation = emp.designation;
            objSagar.SaveChanges();
           
        }
    }
}
