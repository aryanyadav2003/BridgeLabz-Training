using System;
class Factorial2{
static void Main(){
int n=Convert.ToInt32(Console.ReadLine());
int fact=1;
for(int i=n;i>0;i--){
fact*=i;
}
Console.WriteLine(fact);
}
}