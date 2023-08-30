// See https://aka.ms/new-console-template for more information
using C_Assignment;

//implementing DineInRestaurant methods
DineInRestaurant dinein = new DineInRestaurant();
dinein.setDetails("Cafe Coffee Day", "Hyderabad", "8699312689");
dinein.setMenu(new List<string>(){"Cappucino","Espresso","Latte","Americano"});
dinein.setLiveMusic(true);
dinein.getMenu();
Console.WriteLine("Bill in rupees: "+ dinein.calculateBill(3));
Console.WriteLine("Remaining Capacity: "+ dinein.getCapacity(9));
dinein.showAllDetails();
dinein.takeFeedback();


//implementing CloudRestaurant methods
CloudRestaurant cloudr = new CloudRestaurant();
cloudr.setDetails("Lithium", "Bangalore", "7699312689");
cloudr.setMenu(new List<string>() { "Cheese Sandwich", "Chicken Nuggets", "Beef Burger", "Mocktails" });
cloudr.setNoOfDeliveryExecutives(10);
cloudr.getNoOfDeliveryExecutives();
cloudr.getMenu();
Console.WriteLine("Bill in rupees: " + cloudr.calculateBill(6));
Console.WriteLine("Remaining Capacity: " + cloudr.getCapacity(9));
cloudr.showAllDetails();
cloudr.showAllDetails("admin");
cloudr.takeFeedback();

//implementing Waiter methods
Waiter waiter = new Waiter();
waiter.SetEmployeeDetails("Madhu", 31, 20000);
waiter.GetEmployeeDetails();

