namespace Model
{
    public class Trip : Event
    {
        public string Location { get; private set; }
        public int Price { get; private set; }
        public int Experience { get; private set; }
    }
}