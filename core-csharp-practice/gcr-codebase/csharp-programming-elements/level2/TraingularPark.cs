using System;
class TraingularPark{
   static void Main(){ 
     int sides=Convert.ToInt32(Console.ReadLine());
	 int perimeter=3*sides;
	 int rounds=5/perimeter;
	 Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
   }
}