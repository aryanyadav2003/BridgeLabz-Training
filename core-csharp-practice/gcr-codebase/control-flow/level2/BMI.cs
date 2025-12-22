using System;
class BMI{
    static void Main(){
        Console.Write("Enter weight in kg: ");
        double w = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        double heightM = heightCm / 100;
        double bmi = w/(heightM*heightM);
        Console.WriteLine("BMI is: " + bmi);
        if (bmi<18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if(bmi>=18.5 && bmi<24.9)
        {
            Console.WriteLine("Normal");
        }
        else if(bmi>=25 && bmi<39.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Weight Status: Obese");
        }
    }
}
