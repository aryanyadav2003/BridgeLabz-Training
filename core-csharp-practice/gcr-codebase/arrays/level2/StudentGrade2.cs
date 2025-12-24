using System;
class StudentGrade2{
    static void Main(){
        Console.Write("Enter number of students: ");
        int n=int.Parse(Console.ReadLine());
        int[,] marks=new int[n,3];
        double[] percentage=new double[n];
        string[] grade=new string[n];
        for (int i=0;i<n;i++){
            Console.WriteLine($"Enter marks for Student {i+1}");
            Console.Write("Physics: ");
            marks[i,0]=int.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            marks[i,1]=int.Parse(Console.ReadLine());
            Console.Write("Maths: ");
            marks[i,2]=int.Parse(Console.ReadLine());       
        }
        for (int i=0;i<n;i++)
        {
            percentage[i]=(marks[i,0]+marks[i,1]+marks[i,2])/3.0;
            if (percentage[i]>=80)
            grade[i]="Level 4";
            else if (percentage[i]>=70)
            grade[i]="Level 3";
            else if (percentage[i]>=60)
            grade[i]="Level 2";
            else if (percentage[i]>=50)
            grade[i]="Level 1-";
            else if (percentage[i]>=40)
            grade[i]="Level 1";
            else
            grade[i]="F";
        }
        for (int i=0;i<n;i++){
            Console.WriteLine($"{marks[i,0]} {marks[i,1]} {marks[i,2]} {percentage[i]} {grade[i]}");
        }
    }
}
