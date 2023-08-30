using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    public abstract class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public List<string> Menu { get; set; }

        //method to set restaurant details
        public void setDetails(string name, string address, string contactNo)
        {
            Name = name;
            Address = address;
            Contact = contactNo;
        }

        //abstract method getCapacity overriden in child classes
        public abstract int getCapacity(int remainingTables);

        //function to print restaurant Menu
        public void getMenu()
        {
            Console.WriteLine("MENU");
            foreach (var item in Menu)
                Console.WriteLine(item);
        }

        //function to set restaurant menu
        public void setMenu(List<string> menu) {
            Menu = menu;
        }

        //function to calculate total price
        public int calculateBill(int noOfItems) {
            return (noOfItems * 200);
        }

        public void takeFeedback()
        {
            Console.WriteLine("Please give us your valuable feedback");
        }
    }
}
