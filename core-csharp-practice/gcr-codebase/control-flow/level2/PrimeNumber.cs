using System;
class PrimeNumber{
    static void Main(){
	  int n=Convert.ToInt32(Console.ReadLine());
	  int cnt=0;
	  if(n<=1){
	   Console.WriteLine("not a prime number");
	  }
	  else{
	  for(int i=1;i<=n;i++){
	  if(n%i==0){
	  cnt++;
	  }
	  }
	  if(cnt==2){
	  Console.WriteLine("prime number");
	  }
	  else{
	  Console.WriteLine("not a prime number");}
	  }
	}
}