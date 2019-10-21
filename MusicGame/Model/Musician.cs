using System;

namespace Model
{
    public class Musician
    {
        public string Name { get; private set; }
        public Instrument Instrument { get; private set; }
        public string Quirk { get; private set; }
        public int Level { get; private set; }
        public int Price { get; private set; }
    }
}