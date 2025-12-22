using System;
class CountDigits{
static void Main(){
  int n=Convert.ToInt32(Console.ReadLine());
  int cnt=0;
  while(n>0){
    n=n/10;
	cnt++;
  }
  Console.WriteLine(cnt);
}}