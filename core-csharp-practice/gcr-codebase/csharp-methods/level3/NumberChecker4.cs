using System;
class NumberChecker4{
    public static int[] FindFactors(int n){
        int cnt=0;
        for(int i=1;i<=n;i++){
            if(n%i==0) cnt++;
        }
        int[] factors=new int[cnt];
        int index=0;
        for(int i=1;i<=n;i++){
            if(n%i==0) factors[index++]=i;
        }
        return factors;
    }
    public static int GreatestFactor(int[] factors){
        int max=factors[0];
        foreach(int f in factors){
            if (f>max){
                max=f;
        }
		}
        return max;
    }
    public static int SumOfFactors(int[] factors){
        int sum=0;
        foreach(int f in factors){
            sum+=f;
			}
        return sum;
    }
    public static long ProductOfFactors(int[] factors){
        long product=1;
        foreach(int f in factors)
            product*=f;
        return product;
    }
    public static double ProductOfCubes(int[] factors)
    {
        double product=1;
        foreach(int f in factors){
            product*=Math.Pow(f,3);
		}
        return product;
    }
    public static bool IsPerfectNumber(int n, int[] factors){
        int sum=0;
        foreach(int f in factors){
            if (f!=n){
                sum += f;
        }
		}
        return sum==n;
    }
    public static bool IsAbundantNumber(int n, int[] factors){
        int sum=0;
        foreach(int f in factors){
            if(f!=n){
                sum+=f;
        }}
        return sum>n;
    }
    public static bool IsDeficientNumber(int n, int[] factors){
        int sum=0;
        foreach(int f in factors){
            if(f!=n){
                sum+=f;
        }}
        return sum<n;
    }
    public static bool IsStrongNumber(int n){
        int temp=n;
        int sum=0;
        while(temp>0){
            int digit=temp%10;
            sum+=Factorial(digit);
            temp/=10;
        }
        return sum==n;
    }
    public static int Factorial(int n){
        int fact=1;
        for(int i=1;i<=n;i++)
            fact*=i;
        return fact;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n=int.Parse(Console.ReadLine()!);
        int[] factors=FindFactors(n);
        foreach (int f in factors){
          Console.Write(f + " ");
		}
        Console.WriteLine();
        Console.WriteLine("Greatest Factor : " + GreatestFactor(factors));
        Console.WriteLine("Sum of Factors  : " + SumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
        Console.WriteLine("Product of Cubes : " + ProductOfCubes(factors));
        Console.WriteLine("Is Perfect Number : " + IsPerfectNumber(n, factors));
        Console.WriteLine("Is Abundant Number : " + IsAbundantNumber(n, factors));
        Console.WriteLine("Is Deficient Number : " + IsDeficientNumber(n, factors));
        Console.WriteLine("Is Strong Number  : " + IsStrongNumber(n));
    }
}
