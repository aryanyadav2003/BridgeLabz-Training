using System;
class NumberChecker3{
    public static bool IsPrime(int n){
        if(n<=1) return false;
        for(int i=2;i<=Math.Sqrt(n);i++){
            if(n%i==0) return false;
        }
        return true;
    }
    public static bool IsNeon(int n){
        int square=n*n;
        int sum=0;
        while(square>0){
            sum+=square%10;
            square/=10;
        }
        return sum==n;
    }
    public static bool IsSpy(int n){
        int sum=0;
        int product=1;
        int temp=Math.Abs(n);
        while(temp> 0){
            int digit=temp%10;
            sum+=digit;
            product*=digit;
            temp/=10;
        }
        return sum==product;
    }
    public static bool IsAutomorphic(int n){
        int square=n*n;
        return square.ToString().EndsWith(n.ToString());
    }
    public static bool IsBuzz(int n){
        return(n%7==0)||(n%10==7);
    }
    static void Main(){
        Console.Write("Enter a number: ");
        int n =int.Parse(Console.ReadLine());
        Console.WriteLine("Is Prime Number : " + IsPrime(n));
        Console.WriteLine("Is Neon Number : " + IsNeon(n));
        Console.WriteLine("Is Spy Number : " + IsSpy(n));
        Console.WriteLine("Is Automorphic Number: " + IsAutomorphic(n));
        Console.WriteLine("Is Buzz Number : " + IsBuzz(n));
    }
}
