using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    public interface IEmployee
    {
        public void SetEmployeeDetails(string name, int id, double salary);

        public void GetEmployeeDetails();

    }
}
