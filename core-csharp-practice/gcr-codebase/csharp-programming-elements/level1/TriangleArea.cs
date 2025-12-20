using System;

class TriangleArea{
    static void Main(){
        double baseInches = Convert.ToDouble(Console.ReadLine());   
        double heightInches = Convert.ToDouble(Console.ReadLine());
        double areaSqInches = 0.5 * baseInches * heightInches;
        double areaSqCm = areaSqInches * 6.4516;

        Console.WriteLine(
            "The area of triangle is " + areaSqInches +
            " square inches and " + areaSqCm +
            " square centimeters"
        );
    }
}
