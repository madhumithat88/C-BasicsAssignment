using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    //class waiter implements the IEmployee interface
    internal class Waiter : IEmployee
    {

        public string Name;
        public int Id;
        public double Salary;

        public void SetEmployeeDetails(string name, int id, double salary){ 
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void GetEmployeeDetails() {
            Console.WriteLine("Name of the employee: "+ Name);
            Console.WriteLine("Employee ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
