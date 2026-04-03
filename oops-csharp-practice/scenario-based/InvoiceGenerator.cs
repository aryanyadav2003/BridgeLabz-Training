using System;
class InvoiceGenerator{
 static void Main(){
  Console.Write("Enter invoice details:");
  string input = Console.ReadLine();
  //parse invoice
  string[] tasks = ParseInvoice(input);
  
  Console.WriteLine("Invoice Details:");
  for(int i=0 ; i<tasks.Length ; i++){
     Console.WriteLine(tasks[i]);
  }
  //Calculate total
  int total = GetTotalAmount(tasks);
  
  Console.WriteLine("Total invoice amount : " + total + "INR");
}
  static string[] ParseInvoice(string input){
     string[] tasks = input.Split(',');
	 
	 return tasks;
  }
  static int GetTotalAmount(string[] tasks){
     int total=0;
	 for(int i=0 ;i < tasks.Length; i++){
	    string task = tasks[i];
		
		string[] parts = task.Split('-');
		string amountPart = parts[1];
		
		amountPart = amountPart.Replace("INR", "").Trim();
		
		int amount = int.Parse(amountPart);
		total+=amount;
	 }
	 return total;
  }
}