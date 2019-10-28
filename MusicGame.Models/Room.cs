namespace MusicGame.Models
{
    public class Room
    {
        public int Size { get; private set; }
        public int Price { get; private set; }
        public string Location { get; private set; }

        public Room(int size, int price, string location)
        {
            Size = size;
            Price = price;
            Location = location;
        }
    }
}