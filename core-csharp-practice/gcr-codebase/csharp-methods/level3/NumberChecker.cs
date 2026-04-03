using System;
class NumberChecker{
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
  public static bool isDuck(int[] digits){
    foreach(int d in digits){
	  if(d!=0) return true;
	}
	return false;
  }
  public static bool isArmstrong(int n,int[] digits){
    int sum=0;
	int power=digits.Length;
	foreach(int d in digits){
	  sum+=(int)Math.Pow(d,power);
	}
	return sum==Math.Abs(n);
  }
  public static void LargestSecondLargest(int[] digits){
   int largest=Int32.MinValue;
   int secondLargest=Int32.MinValue;
   foreach(int d in digits){
     if(d>largest){
	   secondLargest=largest;
	   largest=d;
	 }
	 else if(d>secondLargest && d!=largest){
	   secondLargest=d;
	 }
   }
   Console.WriteLine("largest digit:" +largest);
   Console.WriteLine("second largest digit:" +secondLargest);
   
  }
  public static void SmallestSecondSmallest(int[] digits){
    int smallest=Int32.MaxValue;
	int secondSmallest=Int32.MaxValue;
	foreach(int d in digits){
	  if(d<smallest){
	    secondSmallest=smallest;
		smallest=d;
	  }
	  else if(d<secondSmallest && d!=smallest){
	   secondSmallest=d;
	  }
	}
	Console.WriteLine("Smallest digit:" +smallest);
	Console.WriteLine("Second smallest digit :" +secondSmallest);
  }
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	int digitCnt=CountDigits(n);
	Console.WriteLine("Digit Count :" + digitCnt);
	int[] digits=StoreDigits(n);
	foreach(int d in digits){
	  Console.Write(d+" ");
	}
	Console.WriteLine();
	Console.WriteLine("Is Duck number :" + isDuck(digits));
	Console.WriteLine("Is armstrong number :" + isArmstrong(n,digits));
	LargestSecondLargest(digits);
	SmallestSecondSmallest(digits);
  }
}