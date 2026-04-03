using System;
class VolumeOfEarth{
	static void Main(){
     double radius=6378;
	 double pi=3.14;
	 double volume=(4/3)*pi*(radius*radius*radius);
	 double miles=radius*1.6;
	 double volumeMiles=(4/3)*pi*(miles*miles*miles);
	 Console.WriteLine("The volume of earth in cubic kilometers is " + volume + " and cubic miles is " + volumeMiles);
}
}