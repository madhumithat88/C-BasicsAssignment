using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    public class DineInRestaurant : Restaurant
    {
        private bool liveMusic;

        //getCapacity method overrides parent class's abstract method
        public override int getCapacity(int remainingTables)
        {
            return remainingTables * 4;
        }

        //function to set live music status
        public void setLiveMusic(bool liveMusic)
        {
            this.liveMusic = liveMusic;
        }

        //function to get live music status
        public void getLiveMusic()
        {
            Console.WriteLine("Live Music: "+ liveMusic);
        }

        //function to print all details
        public void showAllDetails()
        {
            Console.WriteLine("Dine In Restaurant Details");
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Address: "+ Address);
            Console.WriteLine("Contact "+ Contact);
            Console.WriteLine("Live Music Availability: "+ liveMusic);
            Console.WriteLine("Menu: ");
            foreach (var item in Menu)
                Console.WriteLine(item);

        }

    }
}
