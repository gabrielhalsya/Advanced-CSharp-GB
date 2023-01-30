using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Constraint
{
    internal interface IEmployee
    {

    }

    internal class Employee : IEmployee
    {
        public Employee(string? name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string? ToString()
        {
            return $"Name : {Name}, Salary : {Salary}";
        }

        public string? Name { get; set; }
        public double Salary { get; set; }
    }

    internal class EmployeeRepository<T> where T : IEmployee
    {
        readonly List<Employee> employees= new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        
        public void DisplayEmployee()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.ToString()}");
            }
        }

    }
}
