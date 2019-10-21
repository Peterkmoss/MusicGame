namespace Model
{
    public class Concert : Activity
    {
        public string Location { get; private set; }
        public int Price { get; private set; }
        public int Revenue { get; private set; }
        public int Rank { get; private set; }
        public int Experience { get; private set; }
    }
}