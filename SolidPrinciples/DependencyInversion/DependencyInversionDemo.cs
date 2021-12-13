
namespace SolidPrinciples.DependencyInversion
{
    public class DependencyInversionDemo
    {
        public static void Main()
        {
            EmployeeService employeeService = new EmployeeService();
            Employee employee = employeeService.GetEmployeeDetails(1);
            Console.WriteLine($"{ "Name: " + employee.Name}");
        }
    }

    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }
    }

    public interface IEmployeeRepository
    {
        public Employee GetEmployeeById(int id);
    }

    /// <summary>
    /// EmployeeRepository is low-level module
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee()
            {
                ID = id,
                Name = "Jack",
                Department = "IT"
            };
            return employee;
        }
    }

    public class EmployeeRepositoryService
    {
        public static IEmployeeRepository GetEmployeeRepository()
        {
            return new EmployeeRepository();
        }
    }

    /// <summary>
    /// EmployeeService is high-level module
    /// </summary>
    public class EmployeeService
    {
        IEmployeeRepository employeeRepository;
        public EmployeeService()
        {
            employeeRepository = EmployeeRepositoryService.GetEmployeeRepository();
        }

        public Employee GetEmployeeDetails(int id)
        {
            Employee employee = employeeRepository.GetEmployeeById(id);
            return employee;
        }
    }
}
