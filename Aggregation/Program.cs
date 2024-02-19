namespace Aggregation
{
    using System;
    using System.Collections.Generic;

    class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } // Collezione di dipendenti

        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>(); // Inizializzazione della lista di dipendenti
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di un dipartimento
            Department department = new Department("Engineering");

            // Creazione di dipendenti
            Employee emp1 = new Employee("John");
            Employee emp2 = new Employee("Alice");

            // Aggiunta dei dipendenti al dipartimento
            department.AddEmployee(emp1);
            department.AddEmployee(emp2);

            // Stampa dei dipendenti nel dipartimento
            Console.WriteLine($"Employees in {department.Name} department:");
            foreach (Employee emp in department.Employees)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}
