using System;
class StudentMarks{
   public static int[,] GenerateMarks(int n){
     int[,] marks=new int[n,3];
	 Random r=new Random();
	 for(int i=0;i<n;i++){
	   marks[i,0]=r.Next(10,100);
	   marks[i,1]=r.Next(10,100);
	   marks[i,2]=r.Next(10,100);
	 }
	 return marks;
   }
   public static double[,] CalculateResults(int[,] marks){
    int students=marks.GetLength(0);
	double[,] result=new double[students,3];
	for(int i=0;i<students;i++){
	 int total=marks[i,0]+marks[i,1]+marks[i,2];
	 double average=total/3.0;
	 double percentage=(total/300.0)*100;
	 result[i,0]=total;
	 result[i,1]=Math.Round(average);
	 result[i,2]=Math.Round(percentage);
	}
	return result;
   }
   static void Main(){
     int n=int.Parse(Console.ReadLine());
	 int[,] marks=GenerateMarks(n);
	 double[,] results=CalculateResults(marks);
	 Console.WriteLine("\nStudent\tPhy\tChem\tMath\tTotal\tAvg\t%\n");
	 for(int i=0;i<n;i++){
	  Console.WriteLine( (i + 1) + "\t" +
                marks[i, 0] + "\t" +
                marks[i, 1] + "\t" +
                marks[i, 2] + "\t" +
                results[i, 0] + "\t" +
                results[i, 1] + "\t" +
                results[i, 2]
            );
	 }
   }
}