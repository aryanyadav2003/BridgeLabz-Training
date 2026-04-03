using System;
class DistanceConverter{
    static void Main(){
        int distanceInFeet = Convert.ToInt32(Console.ReadLine());
        double yards = distanceInFeet / 3.0;
        double miles = yards / 1760;

        Console.WriteLine(
            "The distance in feet is " + distanceInFeet +
            " while in yards is " + yards +
            " and in miles is " + miles
        );
    }
}
