using System;
class LuckyDraw{
  public int totalVisitor;
  public LuckyDraw(int visitor){
    totalVisitor = visitor;
  }
  public void StartGame(){
    int count = 1;
	while(count<=totalVisitor){
	  Console.Write($"Visitor {count} enter your lucky number : ");
	  int input = int.Parse(Console.ReadLine());
	  if(input<=0){
	   Console.WriteLine("Invalid input!! move to next visitor");
	   count++;
	   continue;
	  }
	  if(input%3 ==0 && input%5==0){
	   Console.WriteLine("Congrts!! you entered lucky number");
	  }
	  else{
	   Console.WriteLine("Better luck next time");
	  }
	  count++;
	}
	Console.WriteLine("\nLucky draw completed.");
  }  
}
class LuckyDrawProgram{
    static void Main(){
        LuckyDraw draw = new LuckyDraw(10);
        draw.StartGame();
    }
}