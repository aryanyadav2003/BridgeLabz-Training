using System;
class NumberChecker1{
  public static int CountDigits(int n){
    int cnt=0;
	n=Math.Abs(n);
	while(n>0){
	  cnt++;
	  n/=10;
	}
	return cnt;
  }
  public static int[] StoreDigits(int n){
   n=Math.Abs(n);
   int cnt=CountDigits(n);
   int[] digits=new int[cnt];
   for(int i=cnt-1;i>=0;i--){
    digits[i]=n%10;
	n/=10;
   }
   return digits;
  }
  public static int SumOfDigits(int[] digits){
   int sum=0;
   foreach(int d in digits){
    sum+=d;
   }
   return sum;
  }
  public static int SumOfSquares(int[] digits){
    int sum=0;
	foreach(int d in digits){
	 sum+=(int)Math.Pow(d,2);
	}
	return sum;
  }
  public static bool IsHarshad(int n,int[] digits){
   int sum=SumOfDigits(digits);
   return sum!=0 && n%sum==0;
  }
  public static int[,] DigitFrequency(int[] digits){
    int[,] freq=new int[10,2];
	for(int i=0;i<10;i++){
	 freq[i,0]=i;
	}
	foreach(int d in digits){
	 freq[d,1]++;
	}
	return freq;
  }
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	int[] digits=StoreDigits(n);
	foreach(int d in digits){
	 Console.Write(d+" ");
	}
	Console.WriteLine();
	Console.WriteLine("Digit count :" + CountDigits(n));
	Console.WriteLine("Sum of Digits :" + SumOfDigits(digits));
	Console.WriteLine("Sum of squares of digits:" + SumOfSquares(digits));
	Console.WriteLine("Is Harshad number :" + IsHarshad(n,digits));
	int[,] freq=DigitFrequency(digits);
	for(int i=0;i<10;i++){
	 if(freq[i,1]>0){
	   Console.WriteLine($"{freq[i,0]}  appears {freq[i,1]} times");
	 }
	}
  }
}