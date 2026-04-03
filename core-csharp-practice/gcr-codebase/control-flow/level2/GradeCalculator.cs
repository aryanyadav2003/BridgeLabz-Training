using System;
class GradeCalculator{
    static void Main(){
        Console.Write("Enter Physics marks: ");
        int physics = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Chemistry marks: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Maths marks: ");
        int maths=Convert.ToInt32(Console.ReadLine());
        double average=(physics+chemistry+maths)/3.0;
        string grade, remarks;
        if(average>=80)
        {
            grade = "Level 4";
            remarks = "above agency-normalized standards";
        }
        else if (average>=70 && average<79)
        {
            grade = "Level 3";
            remarks = "at agency-normalized standards";
        }
        else if (average>=60 && average<69)
        {
            grade = "Level 2";
            remarks = "below,but approaching agency-normalized standards";
        }
        else if (average>=50 && average<59)
        {
            grade = "Level 1-";
            remarks = "well below agency-normalized standards";
        }
		else if (average>=40 && average<49)
        {
            grade = "Level 1";
            remarks = "too below agency-normalized standards";
        }
        else
        {
            grade = "F";
            remarks = "Fail";
        }

        Console.WriteLine("Average Marks : " + average);
        Console.WriteLine("Grade         : " + grade);
        Console.WriteLine("Remarks       : " + remarks);
    }
}
