using System;
class HeightConverter{
    static void Main(){
        double heightCm=Convert.ToDouble(Console.ReadLine());
        double totalInches;
        int feet;
        double inches; 

        totalInches = heightCm / 2.54;

        feet = (int)(totalInches / 12);
        inches = totalInches % 12;

        Console.WriteLine(
            "Your Height in cm is " + heightCm +
            " while in feet is " + feet +
            " and inches is " + inches
        );
    }
}
