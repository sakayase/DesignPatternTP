using DesignPatternTP.Models;

namespace DesignPatternTP.Business.Contracts
{
    public interface IEmployeeBusiness
    {
        public List<Employee> GetEmployees();

        public Employee? ValidateAndAddEmployee(AddEmployeeDTO employee);

        public Employee? RemoveEmployee(string id);

        public Employee? GetEmployee(string id);
    }
}
