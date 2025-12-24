using System;
class FriendsInfo{
 static void Main(){
   string[] names={"Amar","Akbar","Anthony"};
   int[] age=new int[3];
   double[] height=new double[3];
   for(int i=0;i<3;i++){
     Console.WriteLine("Enter age of " + names[i]);
	 age[i]=int.Parse(Console.ReadLine());
	 Console.WriteLine("Enter height of " + names[i]);
	 height[i]=double.Parse(Console.ReadLine());
   }
   int yidx=0;
   int tidx=0;
   for(int i=1;i<3;i++){
     if(age[i]<age[yidx]){
	  yidx=i;
	 }
	 if(height[i]>height[tidx]){
	  tidx=i;
   }
 }
 Console.WriteLine("Youngest Friend : " + names[yidx] + " Age : " + age[yidx]);
 Console.WriteLine("Tallest Friend : " + names[tidx] + " height : " + height[tidx]);
 
}}