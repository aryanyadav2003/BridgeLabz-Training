using System;
class OddEven{
static void Main(){
int n=Convert.ToInt32(Console.ReadLine());
if(n>0){
for(int i=1;i<=n;i++){
if(i%2==0){
Console.WriteLine($"{i} is even");
}
else{
if(i%2==0){
Console.WriteLine($"{i} is odd");
}
}
}}
else{
Console.WriteLine("not a natural number");
}

}
}