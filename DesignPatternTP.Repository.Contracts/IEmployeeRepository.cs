using DesignPatternTP.Models;

namespace DesignPatternTP.Repository.Contracts
{
    public interface IEmployeeRepository
    {

        public List<Employee> GetEmployees();

        public void AddEmployee(Employee employee);

        public Employee? RemoveEmployee(string id);

        public Employee? GetEmployee(string id);
    }
}
