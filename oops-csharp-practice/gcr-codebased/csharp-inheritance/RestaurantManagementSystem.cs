using System;

interface Worker{
  void PerformDuties();
}
class Person{
  public string name;
  public int id;
}
class Chef : Person,Worker{
  public void PerformDuties(){
    Console.WriteLine("Name: " + name);
	Console.WriteLine("ID: " + id);
    Console.WriteLine("Chef prepares food in the kitchen");
  }
}
class Waiter : Person,Worker{
  public void PerformDuties(){
    Console.WriteLine("Name: " + name);
	Console.WriteLine("ID: " + id);
    Console.WriteLine("Waiter serves food to the customers");
  }
}
class RestaurantManagementSystem{
  static void Main(){
    Worker w1=new Chef{name = "aaa", id = 101};
  Worker w2=new Waiter{name = "abb", id = 102};
	w1.PerformDuties();
    Console.WriteLine();
    w2.PerformDuties();
  }
}