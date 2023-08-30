using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class CloudRestaurant : Restaurant
    {
        private int deliveryExecutives;
       
        //getCapacity method overrides parent class's abstract method
        public override int getCapacity(int remainingHours)
        {
            return remainingHours * 5;
        }

        //function to set no. of available delivery executives
        public void setNoOfDeliveryExecutives(int deliveryExec)
        {
            deliveryExecutives = deliveryExec;
        }

        //function to print the no. of available delivery executives
        public void getNoOfDeliveryExecutives()
        {
            Console.WriteLine("No. of available delivery executives: "+ deliveryExecutives);
        }

        //method overloading with showAllDetails functions
        public void showAllDetails()
        {
            Console.WriteLine("Cloud Restaurant Details");
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Address: "+ Address);
            Console.WriteLine("Contact: "+ Contact);
            Console.WriteLine("Menu: ");
            foreach (var item in Menu)
                Console.WriteLine(item);

        }

        public void showAllDetails(string admin)
        {
            Console.WriteLine("Cloud Restaurant Details");
            Console.WriteLine("Name :"+ Name);
            Console.WriteLine("Address: "+ Address);
            Console.WriteLine("Contact: "+ Contact);
            Console.WriteLine("Menu: ");
            foreach (var item in Menu)
                Console.WriteLine(item);
            Console.WriteLine("No. of available delivery executives: " + deliveryExecutives);

        }
    }
}