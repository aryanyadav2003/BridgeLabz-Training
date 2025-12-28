using System;
class PrimeChecker{
    static bool IsPrime(int number){
        if(number<=1){
            return false;
		}
        for(int i=2;i<=Math.Sqrt(number);i++){
            if(number%i==0){
                return false;
        }
		}
        return true;
    }
    static void Main(){
        Console.Write("Enter a number: ");
        int n=int.Parse(Console.ReadLine());
        if (IsPrime(n)){
            Console.WriteLine($"{n} is a Prime Number");
		}
        else{
            Console.WriteLine($"{n} is NOT a Prime Number");
		}
    }
}
