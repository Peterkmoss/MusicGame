namespace MusicGame.Models
{
    public class Soloist : Musician
    {
        public Soloist(string name, Instrument instrument, string quirk, int level, int price) : base(name, instrument, quirk, level, price)
        {
        }
    }
}