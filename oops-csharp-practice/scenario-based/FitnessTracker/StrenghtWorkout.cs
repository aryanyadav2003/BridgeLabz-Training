class StrengthWorkout : Workout{
    public int Reps { get; private set; }
    public StrengthWorkout(string name, int duration, int reps)
        : base(name, duration){
        Reps = reps;
    }
    public override void Track()
    {
        Console.WriteLine($"[Strength] {WorkoutName} - {Duration} mins, Reps: {Reps}");
    }
}
