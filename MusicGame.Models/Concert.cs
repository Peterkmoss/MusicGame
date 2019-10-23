namespace MusicGame.Models
{
    public class Concert : Activity
    {
        
        public string Location { get; private set; }
        public int Price { get; private set; }
        public int Revenue { get; private set; }
        public int RequiredExperience { get; private set; }
        public int Experience { get; private set; }

        public Concert(string location, int price, int revenue, int rank, int experience)
        {
            Location = location;
            Price = price;
            Revenue = revenue;
            RequiredExperience = rank;
            Experience = experience;
        }
    }
}