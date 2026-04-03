using System;
class AbundantNumber{
  static void Main(){
    int n=Convert.ToInt32(Console.ReadLine());
	int sum=0;
	for(int i=1;i<n;i++){
	 if(n%i==0){
	   sum+=i;
	 }
	}
	if(sum>n){
	 Console.WriteLine("Abundant Number");
	}
	else{
	 Console.WriteLine("not a Abundant Number");	
	}
  }
}