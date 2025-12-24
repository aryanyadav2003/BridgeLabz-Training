using System;
class StudentGrade{
    static void Main(){
        Console.Write("Enter number of students: ");
        int n=int.Parse(Console.ReadLine());
        int[] p=new int[n];
        int[] c=new int[n];
        int[] m=new int[n];
        double[] percentage=new double[n];
        string[] grade = new string[n];
        for (int i = 0; i < n; i++){
            Console.WriteLine($"Enter marks for Student {i+1}");
            Console.Write("Physics: ");
            p[i]=int.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            c[i]=int.Parse(Console.ReadLine());
            Console.Write("Maths: ");
            m[i]=int.Parse(Console.ReadLine());       
        }
        for (int i=0;i<n;i++)
        {
            percentage[i]=(p[i]+c[i]+m[i])/3.0;
            if (percentage[i] >= 80)
            grade[i] = "Level 4";
            else if (percentage[i] >= 70)
            grade[i] = "Level 3";
            else if (percentage[i] >= 60)
            grade[i] = "Level 2";
            else if (percentage[i] >= 50)
            grade[i] = "Level 1-";
            else if (percentage[i] >= 40)
            grade[i] = "Level 1";
            else
            grade[i] = "F";
        }
        for (int i = 0; i < n; i++){
            Console.WriteLine($"{p[i]} {c[i]} {m[i]} {percentage[i]} {grade[i]}");
        }
    }
}
