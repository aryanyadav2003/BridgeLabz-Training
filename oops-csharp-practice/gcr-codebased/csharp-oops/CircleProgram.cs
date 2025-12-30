using System;
class Circle{
  public double radius;
  public double CalculateArea(){
    retrun Math.PI*radius*radius;
  }
  public double CalculateCircumference(){
    retrun 2*Math.PI*radius;
  }
}
class CircleProgram{
  static void Main(){
    Circle c=new Circle();
	Console.Write("Enter radius: ");
	c.radius=double.Parse(Console.ReadLine());
	Console.WriteLine("Area:" + c.CalculateArea);
	Console.WriteLine("Circumference: " + c.CalculateCircumference());
  }
}