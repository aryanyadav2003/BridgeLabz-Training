using System;
class Circle{
    public double Radius;
    public Circle() : this(1.0)   // constructor chainin
	{
    }

    public Circle(double radius){
        Radius = radius;
    }
    public void CalculateArea(){
        double area = 3.14 * Radius * Radius;
        Console.WriteLine("Area of Circle: " + area);
    }
}
class CircleProgram{
    static void Main()
    {
        // Using default constructor
        Circle c1 = new Circle();
        c1.CalculateArea();

        // Using parameterized constructor
        Circle c2 = new Circle(5);
        c2.CalculateArea();
    }
}
