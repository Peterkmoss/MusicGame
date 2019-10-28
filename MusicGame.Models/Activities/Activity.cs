namespace MusicGame.Models.Activities
{
    public abstract class Activity
    {
        public int Duration { get; private set; }

        public Activity(int duration)
        {
            Duration = duration;
        }
    }
}