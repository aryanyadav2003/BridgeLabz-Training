class CardioWorkout : Workout
{
    public int Distance { get; private set; } 
    public CardioWorkout(string name, int duration, int distance)
        : base(name, duration){
        Distance = distance;
    }
    public override void Track()
    {
        Console.WriteLine($"[Cardio] {WorkoutName} - {Duration} mins, {Distance} km");
    }
}
