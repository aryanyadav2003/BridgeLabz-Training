using System;
class OddEvenArray{
   static void Main(){
     int n=int.Parse(Console.ReadLine());
	 if(n<=0){
	   Console.WriteLine("Enter natural number");
	   return;
	 }
	 
	 int[] e=new int[n/2+1];
	 int[] o=new int[n/2+1];
	 int eidx=0;
	 int oidx=0;
	 for(int i=1;i<=n;i++){
	   if(i%2==0){
	     e[eidx++]=i;
	   }
	   else{
	     o[oidx++]=i;
	   }
	 }
	 for(int i=0;i<eidx;i++){
	   Console.Write(e[i]);
	 }
	 Console.WriteLine();
	 for(int i=0;i<oidx;i++){
	   Console.Write(o[i]);
	 }
   }
}