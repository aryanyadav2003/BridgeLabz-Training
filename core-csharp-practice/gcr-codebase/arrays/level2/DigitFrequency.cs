using System;
class DigitFrequency{
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	int temp=n;
	int cnt=0;
	while(temp!=0){
	  cnt++;
	  temp=temp/10;
	}
	int[] digits=new int[cnt];
	temp=n;
	for(int i=0;i<cnt;i++){
	 digits[i]=temp%10;
	 temp=temp/10;
	}
	int[] freq=new int[10];
	for(int i=0;i<cnt;i++){
	  freq[digits[i]]++;
	}
	for(int i=0;i<10;i++){
	 if(freq[i]>0){
	   Console.WriteLine($"{i} occurs {freq[i]} times");
	 }
	}
  }
}