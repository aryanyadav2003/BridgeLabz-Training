using System;
class NumberChecker2{
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
  public static int[] ReverseArray(int[] digits){
   int[] reversed=new int[digits.Length];
   int j=0;
   for(int i=digits.Length-1;i>=0;i--){
      reversed[j++]=digits[i];
   }
   return reversed;
  }
   public static bool CompareArrays(int[] arr1,int[] arr2){
        if(arr1.Length!=arr2.Length) return false;
        for(int i=0;i<arr1.Length;i++){
            if(arr1[i]!=arr2[i])  return false;
        }
        return true;
    }
	public static bool isPallindrome(int[] digits){
	  int[] reversed=ReverseArray(digits);
	  return CompareArrays(digits,reversed);
	}
    public static bool isDuck(int[] digits){
    foreach(int d in digits){
	  if(d!=0) return true;
	}
	return false;
  }
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	int[] digits=StoreDigits(n);
	foreach(int d in digits){
	  Console.Write(d+" ");
	}
	Console.WriteLine();
	int[] reversed=ReverseArray(digits);
	foreach(int d in reversed){
	  Console.Write(d+" ");
	}
	Console.WriteLine();
	Console.WriteLine("Is Palindrome: " + isPallindrome(digits));
    Console.WriteLine("Is Duck Number: " + isDuck(digits));
  }
}