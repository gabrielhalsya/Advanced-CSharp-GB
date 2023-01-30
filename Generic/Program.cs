
using System;
using Generic.Constraint;
using Generic.Interface;

namespace Generic
{
    internal class Program
    {
        public static void Main(string[] args) {
            
            
            
            //Generic Constraint
            Employee emp1 = new("Gabriel", 8_000_000); //defining employee row
            Employee emp2 = new("Rayhan",8_000_000);
            Employee emp3 = new("Alief", 9_000_000);
            //the repository datatype generic must be inherit Interface, see the classes method
            EmployeeRepository<Employee> employeeRepository = new EmployeeRepository<Employee>();
            employeeRepository.AddEmployee(emp1);
            employeeRepository.AddEmployee(emp2);
            employeeRepository.AddEmployee(emp3);
            employeeRepository.DisplayEmployee();


            //Generic Interface
            Console.WriteLine("//Generic Interface");
            Ivehicle<String> vehicle = new Car<String>();
            string color = vehicle.Getcolor("Blue");
            vehicle.Infovehicle();
            Console.WriteLine(color);

        }

    }

}
