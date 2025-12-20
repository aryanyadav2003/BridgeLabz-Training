using System;
class PenDistribution{
   static void Main(){
      int pen=14;
	  int st=3;
	  int penPerPerson=pen/st;
	  int remaining=pen%st;
	  Console.WriteLine("The Pen Per Student is " + penPerPerson +  "and the remaining pen not distributed is " + remaining);
   }
}