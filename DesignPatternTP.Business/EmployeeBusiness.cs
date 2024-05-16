using DesignPatternTP.Business.Contracts;
using DesignPatternTP.Models;
using DesignPatternTP.Repository.Contracts;

namespace DesignPatternTP.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeBusiness(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public Employee? GetEmployee(string id)
        {
            return _repository.GetEmployee(id);
        }

        public List<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }

        public Employee? RemoveEmployee(string id)
        {
            return _repository.RemoveEmployee(id);
        }

        public Employee? ValidateAndAddEmployee(AddEmployeeDTO employeeDTO)
        {
            var id = Guid.NewGuid().ToString();
            if (employeeDTO.Salary <= 0) throw new ArgumentException(message: "The salary must be superior to 0.");
            var newEmployee = new Employee { Salary = employeeDTO.Salary, FirstName = employeeDTO.FirstName, LastName = employeeDTO.LastName, ID = id };
            _repository.AddEmployee(newEmployee);
            return newEmployee;
        }
    }
}
