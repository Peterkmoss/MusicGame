namespace MusicGame.Models.Activities
{
    public class Trip : ExternalActivity
    {
        public Trip(int duration, int price, string location, int experience)
        : base(duration, price, location, experience)
        {
        }
    }


}