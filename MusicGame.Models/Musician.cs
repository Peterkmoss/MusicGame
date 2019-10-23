using System;

namespace MusicGame.Models
{
    public class Musician
    {
       
        public string Name { get; private set; }
        public Instrument Instrument { get; private set; }
        public string Quirk { get; private set; }
        public int Level { get; private set; }
        public int Price { get; private set; }

         public Musician(string name, Instrument instrument, string quirk, int level, int price)
        {
            this.Name = name;
            this.Instrument = instrument;
            this.Quirk = quirk;
            this.Level = level;
            this.Price = price;
        }
    }
}