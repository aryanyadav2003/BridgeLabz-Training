using System;
class GreatestFactor{
    static void Main(){
        int n=Convert.ToInt32(Console.ReadLine());
        int gf=1;

        for (int i=n-1;i>=1;i--){
            if (n%i == 0){
                gf=i;
                break;
            }
        }
        Console.WriteLine(gf);
    }
}
