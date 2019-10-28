namespace MusicGame.Models.Activities
{
    public abstract class ExternalActivity : Activity
    {
        public int Price { get; private set; }
        public string Location { get; private set; }
        public int Experience { get; private set; }

        public ExternalActivity(int duration, int price, string location, int experience) : base(duration)
        {
            Price = price;
            Location = location;
            Experience = experience;
        }
    }
}