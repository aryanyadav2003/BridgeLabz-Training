using System;
class SideOfSquare{
   static void Main(){
      int perimeter=Convert.ToInt32(Console.ReadLine());
	  int side=(perimeter/4);
	  Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
   }
}