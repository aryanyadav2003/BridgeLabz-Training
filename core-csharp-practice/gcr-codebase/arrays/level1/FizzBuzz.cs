using System;
class FizzBuzz{
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	if(n<0){
	 Console.WriteLine("Enter positive number");
	 return;
	}
	string[] ans=new string[n+1];
	for(int i=1;i<=n;i++){
	  if(i%3==0 && i%5==0){
	    ans[i]="FizzBuzz";
	  }
	  else if(i%3==0){
	    ans[i]="Fizz";
	  }
	  else if(i%5==0){
	    ans[i]="Buzz";
	  }
	  else{
	    ans[i]=i.ToString();
	  }
	}
	for(int i=1;i<=n;i++){
	   Console.WriteLine($"Position {1} =" + ans[i]);
	}
  }
}