using DesignPatternTP.Business;
using DesignPatternTP.Business.Contracts;
using DesignPatternTP.Controllers;
using DesignPatternTP.Repository;
using DesignPatternTP.Repository.Contracts;
using Unity;

IUnityContainer container = new UnityContainer();

container.RegisterType<IEmployeeBusiness, EmployeeBusiness>();
container.RegisterType<IEmployeeRepository, EmployeeRepository>();
EmployeeController employeeController = container.Resolve<EmployeeController>();


Console.WriteLine("Hello, World!");
var employees = employeeController.GetEmployees();

foreach (var employee in employees)
{
    Console.WriteLine(employee.ID + " | " + employee.FirstName + " | " + employee.LastName+ " | " + employee.Salary);
}
