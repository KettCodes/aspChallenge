using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.Models;

namespace VogCodeChallenge.API.Services
{
    public class DataService : IDataService
    {
        private readonly List<Employee> lstEmployee = new List<Employee>();
        public DataService()
        {
            Employee employee = new Employee
            {
                Id = 0,
                FirstName = "Blaine",
                LastName = "Retski",
                JobTitle = "Centre of Production",
                Address = "99 Edmonton Canada",
                Department = 0
            };
            lstEmployee.Add(employee);
            employee = new Employee
            {
                Id = 1,
                FirstName = "Wario",
                LastName = "LeMoe",
                JobTitle = "Centre of Production",
                Address = "66 Pittsburgh USA",
                Department = 1
            };
            lstEmployee.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Robby",
                LastName = "Ore",
                JobTitle = "Shutdown Lead",
                Address = "4 Boston USA",
                Department = 1
            };
            lstEmployee.Add(employee);
        }

        private readonly List<Department> lstDepartment = new List<Department>();
        public DataService()
        {
            Department department = new Department
            {
                Id = 0,
                Name = "Western Conference",
                Address = "Western Canada"
            };
            lstDepartment.Add(department);
            department = new Department
            {
                Id = 1,
                Name = "Eastern Conference",
                Address = "Eastern USA"
            };
            lstDepartment.Add(department);
        }

        public IList<Employee> ListAll
        {
            return null;
        }

        public IEnumerable<Employee> GetAll()
        {
            foreach (var emp in lstEmployee)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }
    }
}
