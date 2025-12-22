using System;
class Power{
   static void Main(){
      int n=Convert.ToInt32(Console.ReadLine());
	  int p=Convert.ToInt32(Console.ReadLine());
	  int res=1;
	  for(int i=1;i<=p;i++){
	    res=res*n;
	  }
	  Console.WriteLine(res);
   }

}