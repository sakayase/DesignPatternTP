using DesignPatternTP.Business.Contracts;
using DesignPatternTP.Models;

namespace DesignPatternTP.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeBusiness _business;
        public EmployeeController(IEmployeeBusiness business)
        {
            _business = business;
        }

        public List<Employee> GetEmployees()
        {
            return _business.GetEmployees();
        }

        public Employee? AddEmployee(AddEmployeeDTO employee)
        {
            return _business.ValidateAndAddEmployee(employee);
        }

        public Employee? GetEmployee(string id)
        {
            return _business.GetEmployee(id);
        }

        public Employee? RemoveEmployee(string id)
        {
            return _business.RemoveEmployee(id);
        }

    }
}
