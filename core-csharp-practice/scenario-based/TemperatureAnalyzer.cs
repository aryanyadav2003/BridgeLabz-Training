using System;
class TemperatureAnalyzer{
static void Main(){
   Random rand=new Random();
   float[,] temperatures = new float[7,24];
   for(int day=0;day<7;day++){
     Console.Write($"Day {day+1} temperatures: ");
	 for(int hour=0;hour<24;hour++){
	    temperatures[day,hour] = rand.Next(-5,42);
		Console.Write(temperatures[day,hour] + " ");
	 }
	 Console.WriteLine("");
   }
   int hottestDay = FindHottestday(temperatures);
   int coldestDay = FindColdestDay(temperatures);
   
   Console.WriteLine($"Hottest Day: Day {hottestDay+1}");
   Console.WriteLine($"Coldest Day: Day {coldestDay+1}");
   Console.WriteLine($"Average temperature per day : ");
   float[] averages=AverageTemperaturePerDay(temperatures);
   for(int i=0 ; i<averages.Length ;i++){
      Console.WriteLine($"Day {i+1} : {averages[i]}");
   }  
}
   //Hottest Day
   static int FindHottestday(float[,] temp){
     float maxTemp = temp[0,0];
	 int hottestDay = 0;
	 for(int day=0 ; day<7 ; day++){
	   for(int hour = 0 ; hour <24 ;hour++){
	      if(temp[day,hour]>maxTemp){
		     maxTemp=temp[day,hour];
			 hottestDay=day;
		  }
	   }
	 }
	 return hottestDay;
   }
  //Coldest Day
  static int FindColdestDay(float[,] temp){
    float minTemp = temp[0,0];
	int coldestDay = 0;
	for(int day=0; day < 7; day++){
	  for(int hour = 0;hour < 24; hour++){
	    if(temp[day,hour] < minTemp){
		  minTemp = temp[day,hour];
		  coldestDay = day;
		}
	  }
	}
	return coldestDay;
  }
  //Average Temperatures per Day
  static float[] AverageTemperaturePerDay(float[,] temp){
     float[] avg = new float[7];
	 for(int day=0 ;day < 7 ; day++){
	   float sum=0;
	   for(int hour = 0;hour < 24 ;hour ++){
	     sum+=temp[day,hour];
	   }
	   avg[day]=sum/24;
	 }
	 return avg;
  }  
}