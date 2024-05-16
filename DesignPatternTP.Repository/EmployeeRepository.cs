using DesignPatternTP.Models;
using DesignPatternTP.Repository.Contracts;

namespace DesignPatternTP.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly LocalStorage _storage;
        public EmployeeRepository()
        {
            _storage = LocalStorage.Instance;
        }

        public List<Employee> GetEmployees()
        {
            return _storage.Employees;
        }

        public void AddEmployee(Employee employee)
        {
            _storage.Employees.Add(employee);
        }

        /// <summary>
        /// Delete an employee if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Returns deleted employee, or null if not found</returns>
        public Employee? RemoveEmployee(string id) 
        {
            Employee? employee = _storage.Employees.FirstOrDefault(e => e.ID == id);
            if (employee != null) _storage.Employees.Remove(employee);
            return employee;
        }

        public Employee? GetEmployee(string id)
        {
            return _storage.Employees.FirstOrDefault(e => e.ID == id);
        }
    }
}
