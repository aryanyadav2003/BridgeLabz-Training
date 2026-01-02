using System;
class CafeteriaMenu{
  static string[] menuItems ={"Veg Sandwich",
        "Burger",
        "French Fries",
        "Pasta",
        "Pizza",
        "Coffee",
        "Tea",
        "Cold Drink",
        "Samosa",
        "Ice Cream"};
    static void Main(){
	  DisplayMenu();
	  
	  Console.Write("enter item index to order:");
	  int index = int.Parse(Console.ReadLine());
	  
	  string item = GetItemByIndex(index-1);
	  
	  if(item != null ){
	    Console.WriteLine("You have ordered:" + item);
	  }
	  else{
	    Console.WriteLine("Invalid item selection!");
	  }
	}
	//Method to display menu
	static void DisplayMenu(){
	   Console.WriteLine("----- Cafeteria Menu -----");
	   for (int i = 0; i < menuItems.Length; i++){
            Console.WriteLine($"{i+1} : {menuItems[i]}");
        }
	}
	//  Method to get item by index
	static string GetItemByIndex(int index){
	   if(index >= 0 && index < menuItems.Length){
	      return menuItems[index];
	   }
	   return null;
	}
}