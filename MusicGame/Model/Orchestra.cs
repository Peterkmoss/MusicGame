using System.Collections.Generic;
namespace Model
{
    public class Orchestra : IOrchestra
    {
        public int Experience { get; private set; }
        public ISet<Musician> Musicians { get; private set; }
        public Room PracticeRoom { get; private set; }
        public string Name { get; set; }
        public int Budget { get; private set; }
        public IDictionary<int, IList<Activity>> Schedule { get; private set; }
        public int WeeklyHours { get; private set; }
        public int PracticeHours { get; private set; }

        public Orchestra(string name, ISet<Musician> musicians, IDictionary<int, IList<Activity>> schedule)
        {
            Experience = 0;
            Musicians = musicians;
            PracticeRoom = new Room();
            Name = name;
            Budget = 1000;
            Schedule = schedule;
            WeeklyHours = 1;
            PracticeHours = 0;
        }

        public void RunScheduledWeek()
        {
            throw new System.NotImplementedException();
        }

        public void BuyMusician(Musician musician)
        {
            throw new System.NotImplementedException();
        }

        public void BuyEvent(Activity activity)
        {
            throw new System.NotImplementedException();
        }

        public void BuyPracticeRoom(Room practiceRoom)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSchedule(int day, IList<Activity> activities)
        {
            throw new System.NotImplementedException();
        }
    }
}