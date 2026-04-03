using System;
class CompareSum{
 static void Main(){
  int n=Convert.ToInt32(Console.ReadLine());
  int total=0;
  int sum=n*(n+1)/2;;
  if(n>=0){
  while(n!=0){
    total+=n;
	n--;
  }
  }
  else{
  Console.WriteLine("not a natural number");
  }
  if(sum==total){
  Console.WriteLine(sum);
  }
}
}