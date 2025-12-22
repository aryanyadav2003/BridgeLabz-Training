using System;
class Factorial{
static void Main(){
int n=Convert.ToInt32(Console.ReadLine());
int fact=1;
while(n!=1){
fact=fact*n;
n--;
}
Console.WriteLine(fact);
}
}