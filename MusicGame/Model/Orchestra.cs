using System.Collections.Generic;
namespace Model
{
    public class Orchestra
    {
        public int Level { get; private set; }
        public ISet<Musician> Musicians { get; private set; }
        public Room PracticeRoom { get; private set; }
        public string Name { get; private set; }
        public int Budget { get; private set; }
        public Schedule Schedule { get; private set; }
        public int WeeklyHours { get; private set; }
        public int PracticeHours { get; private set; }
    }
}