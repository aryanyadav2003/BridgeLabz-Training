using System;
class LibraryManagementSystem{
 static string[] status;
 static void Main(){
  //Book details
  Console.Write("Enter total number of books : ");
  int n = int.Parse(Console.ReadLine());
  //title,author
  string[,] bookDetails = new string[n,2];
  status =new string[n];
  for(int i=0 ;i<n ;i++){
    Console.WriteLine($"Enter details for book {i+1} : ");
	Console.Write("title :");
	bookDetails[i,0] = Console.ReadLine();
	
	Console.Write("author :");
	bookDetails[i,1] = Console.ReadLine();
	
	status[i]="Available";
	
  }
  while(true){
    Console.WriteLine("1. Display all books.");
	Console.WriteLine("2. Search book by title.");
	Console.WriteLine("3. Checkout / return books.");
	Console.WriteLine("4. Add book ");
	Console.WriteLine("5. Update book ");
	Console.WriteLine("6. exit");
	Console.Write("Enter your choice : ");
	int choice = int.Parse(Console.ReadLine());
	switch(choice){
	    case(1):
	      DisplayBooks(bookDetails,status);
		  break;
	    case(2):
		  Console.Write("Enter title of the book :");
		  string title=Console.ReadLine();
		  SearchBookByTitle(bookDetails,status,title);
		  break;
		case(3):
		  Console.Write("Enter title of the book :");
		  string Updatetitle = Console.ReadLine();
		  CheckAndUpdateStatus(bookDetails,status,Updatetitle);
		  break;
		case(4):
		   bookDetails=AddBook(bookDetails);
		   break;
		case(5):
		    UpdateBook(bookDetails);
			break;
		case(6):
		   Console.WriteLine("Exiting Library System...");
		   return;
		default:
		  Console.WriteLine("Invalid choice.");
		  return;
	}
  }
  }
  static void DisplayBooks(string[,] bookDetails,string[] status){
    for(int i=0 ; i<bookDetails.GetLength(0) ;i++){
	  Console.WriteLine($"Title : {bookDetails[i,0]} , Author : {bookDetails[i,1]} , Status : {status[i]}");
	}
  }
  static void SearchBookByTitle(string[,] bookDetails, string[] status , string title){
   bool found=false;
   for(int i=0 ; i<bookDetails.GetLength(0) ; i++){
     if(bookDetails[i,0].ToLower().Contains(title.ToLower())){
	   Console.WriteLine($"Book is Available -> Title : {bookDetails[i,0]} , Author : {bookDetails[i,1]} , Status : {status[i]}");
	   found = true;
	 }
   }
   if(!found){
     Console.WriteLine("Book is not available");
   }
  }
  static void CheckAndUpdateStatus(string[,] bookDetails,string[] status,string title){
    for(int i=0 ; i<bookDetails.GetLength(0) ; i++){
	 if(bookDetails[i,0].ToLower().Contains(title.ToLower())){
	    if(status[i] == "Available"){
		  status[i] = "Checked Out";
		  Console.WriteLine("Book checked out successfully");
		}
		else{
		  status[i] = "Available";
		  Console.WriteLine("Book returned successfully");
		}
		return;
	 }
	}
	Console.WriteLine("Book not found");
  }
  
  static string[,] AddBook(string[,] books){
	 int oldSize=books.GetLength(0);
	 string[,] newbooks=new string[oldSize+1,2];
	 string[] newStatus=new string[oldSize+1];
	 for(int i=0 ;i<oldSize; i++){
		 newbooks[i,0]=books[i,0];
		 newbooks[i,1]=books[i,1];
		 newStatus[i]=status[i];
	 }
	 Console.Write("New Title : ");
	 newbooks[oldSize,0]=Console.ReadLine();
	 Console.Write("New Author: ");
	 newbooks[oldSize,1]=Console.ReadLine();
	 
	 newStatus[oldSize]="Available";
	 status=newStatus;
	 
	 Console.WriteLine("Book added successfully.");
	 return newbooks;
  }
  
  static void UpdateBook(string[,] books){	  
	  Console.Write("Enter title to update : ");
	  string title=Console.ReadLine();
	  for(int i=0;i<books.GetLength(0);i++){
		  
		  if(books[i,0].ToLower().Contains(title.ToLower())){
			  Console.Write("New title : ");
			  books[i,0]=Console.ReadLine();
			  
			  Console.Write("New author : ");
			  books[i,1]=Console.ReadLine();
			  
			  Console.WriteLine("Book updated.");
			  return;
		  }
	  }
	  Console.WriteLine("Book not found.");
  }
}