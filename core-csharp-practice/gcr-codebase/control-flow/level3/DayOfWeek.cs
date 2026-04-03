using System;
class DayOfWeek{
static void Main(){
  int m=Convert.ToInt32(Console.ReadLine());
  int d=Convert.ToInt32(Console.ReadLine());
  int y=Convert.ToInt32(Console.ReadLine());
  int Y=y-(14-m)/12;
  int x=Y+Y/4-Y/100+Y/400;
  int M=m+12*((14-m)/12)-2;
  int D=(d+x+31*M/12)%7;
  Console.WriteLine(D);
}}