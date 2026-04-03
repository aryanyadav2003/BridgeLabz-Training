abstract class Workout : ITrackable
{
    public string WorkoutName { get; protected set; }
    public int Duration { get; protected set; }
    protected Workout(string name, int duration)
    {
        WorkoutName = name;
        Duration = duration;
    }
    public abstract void Track();
}
