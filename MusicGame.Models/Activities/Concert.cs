namespace MusicGame.Models.Activities
{
    public class Concert : ExternalActivity
    {

        public int Revenue { get; private set; }
        public int RequiredExperience { get; private set; }

        public Concert(int duration, int price, string location, int experience, int revenue, int requiredExperience)
        : base(duration, price, location, experience)
        {
            Revenue = revenue;
            RequiredExperience = requiredExperience;
        }
    }
}