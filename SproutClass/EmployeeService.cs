using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SproutClass
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployeesData()
        {
            var result = new List<Employee>();
            //var listfromdb = databaseService.GetEmployees();
            //add the list of employees to the 'result' object

            //Sampe data
            result.Add(new Employee { FirstName = "Harry", LastName = "Potter", UniqueId=1});
            var salaryServiceData = new EmployeeSalaryService();
            var salaries = salaryServiceData.GetEmployeesData();
            result.ForEach(x =>
            {
                var salaryData = salaries.First(y => y.UniqueId == x.UniqueId);
                x.Salary = salaryData.Salary;
            });
            return result;
        }

    }
}
