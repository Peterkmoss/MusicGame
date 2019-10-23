namespace MusicGame.Models
{
    public class Trip : Activity
    {
        public string Location { get; private set; }
        public int Price { get; private set; }
        public int Experience { get; private set; }

        public Trip(string location, int price, int experience)
        {
            Location = location;
            Price = price;
            Experience = experience;
        }
    }


}