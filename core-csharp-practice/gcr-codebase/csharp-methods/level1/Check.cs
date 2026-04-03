using System;
class Check{
   static void Checker(int a){
     if(a<0){
	  Console.WriteLine("negative");	  
	 }
	 else if(a==0){
	  Console.WriteLine("zero");  
	 }
	 else{
	   Console.WriteLine("positive");
	 }
   }
   static void Main(){
    int n=int.Parse(Console.ReadLine());
	Checker(n);
	//Console.WriteLine(ans);
   }
}