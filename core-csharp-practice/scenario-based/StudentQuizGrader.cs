using System;
class StudentQuizGrader{
  static void Main(){
    string[] correctAnswers = {"A","C","B","B","A","C","D","A","B","C"};
	string[] studentAnswers = new string[10];
	int score=0;
	while(true){
		Console.WriteLine("1. Start Quiz and generate answer");
		Console.WriteLine("2. Show Feedback");
		Console.WriteLine("3. Calculate Score");
		Console.WriteLine("4. Show Result");
		Console.WriteLine("5. Exit");
		Console.Write("Enter choice : ");
		
		int choice = int.Parse(Console.ReadLine());
		switch(choice){
			case 1:
			   GenerateAnswer(studentAnswers);
			   Console.WriteLine("Student Answer generated");
			   break;
			case 2:
			   ShowFeedback(correctAnswers,studentAnswers);
			   break;
			case 3:
			   score = CalculateScore(correctAnswers,studentAnswers);
			   Console.WriteLine($"Student score is {score}/10");
			   break;
			case 4:
			   ShowResult(score);
			   break;
			case 5:
			   Console.WriteLine("Exiting qiuz...");
			   return;
			default:
			    Console.WriteLine("Invalid choice.");
				break;
		}
  }}
	//Generate Answer
	static void GenerateAnswer(string[] studentAnswers){
		string[] options={"A","B","C","D"};
		Random r=new Random();
		for(int i=0; i<studentAnswers.Length ;i++){
			studentAnswers[i]=options[r.Next(4)];
		}
	}
	//Feedback
	static void ShowFeedback(string[] correctAnswers,string[] studentAnswers){
		for(int i=0; i < correctAnswers.Length ; i++){
			if(correctAnswers[i].Equals(studentAnswers[i],StringComparison.OrdinalIgnoreCase)){
				Console.WriteLine($"Question {i+1} : Correct");
			}
			else{
				Console.WriteLine($"Question {i+1} : Incorrect");
			}
		}
	}
	//Calculate Scores
	static int CalculateScore(string[] correctAnswers,string[] studentAnswers){
		int score=0;
		for(int i=0;i<correctAnswers.Length;i++){
            if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase)){
                score++;
        }
		}
		return score;
	}
	//Show Result
	static void ShowResult(int score){
		double percentage=(score/10.0)*100;
		
		//Console.WriteLine($"Score : {score}/10");
		Console.WriteLine($"percentage : {percentage}%");
		
		if(percentage>=50){
			Console.WriteLine("Result : Pass");
		}
		else{
			Console.WriteLine("Result : Fail");
		}
	}
	
 }
