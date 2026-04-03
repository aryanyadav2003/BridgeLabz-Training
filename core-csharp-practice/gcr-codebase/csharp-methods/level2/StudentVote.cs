using System;
public class StudentVote{
  public static bool CanVote(int age){
   if(age<0){
    return false;
   }
   if(age>=18) return true;
   else return false;
  }
  static void Main(){
    int[] ages=new int[10];
	for(int i=0;i<10;i++){
	 Console.WriteLine($"Enter age of student {i+1}:");
	 ages[i]=int.Parse(Console.ReadLine());
	 bool a=CanVote(ages[i]);
	 
	 if(a){
	  Console.WriteLine("Can Vote");
	 } 
	 else{
	  Console.WriteLine("Cannot Vote");
	 }
	}
  }
}