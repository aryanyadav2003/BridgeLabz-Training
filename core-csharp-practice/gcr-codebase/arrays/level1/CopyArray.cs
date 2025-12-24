using System;
class CopyArray{
  static void Main(){
    int rows=int.Parse(Console.ReadLine());
	int columns=int.Parse(Console.ReadLine());
	int[,] matrix=new int[rows,columns];
	int[] arr=new int[rows*columns];
	for(int i=0;i<rows;i++){
	  for(int j=0;j<columns;j++){
	    matrix[i,j]=int.Parse(Console.ReadLine());
	  }
	}
	int idx=0;
	for(int i=0;i<rows;i++){
	  for(int j=0;j<columns;j++){
	    arr[idx]=matrix[i,j];
		idx++;
	  }
	}
	for(int i=0;i<arr.Length;i++){
	 Console.Write(arr[i] + " ");
	}
  }
}