using System;
class CalculateSimpleInterest{
    static void Main(){
        double principal=1000.0;
        double rate=5.0;
        double time=2.0;
        double si=(principal*rate*time)/100.0;
        Console.WriteLine(si);
    }
}