using System.Collections.Generic;
using MusicGame.Models.Activities;
using MusicGame.Models.Exceptions;

namespace MusicGame.Models
{
    public class Orchestra : IOrchestra
    {
        public int Experience { get; private set; }
        public ISet<Musician> Musicians { get; private set; }
        public ISet<Activity> UnusedActivities { get; private set; }
        public Room PracticeRoom { get; private set; }
        public string Name { get; set; }
        public int Budget { get; private set; }
        public IDictionary<int, IList<Activity>> Schedule { get; private set; }
        public int WeeklyHours { get; private set; }
        public int PracticeHours { get; private set; }

        public Orchestra(string name, ISet<Musician> musicians, IDictionary<int, IList<Activity>> schedule, ISet<Activity> activities)
        {
            Experience = 0;
            Musicians = musicians;
            PracticeRoom = new Room();
            Name = name;
            Budget = 1000;
            Schedule = schedule;
            WeeklyHours = 1;
            PracticeHours = 0;
            UnusedActivities = activities;
        }

        public void RunScheduledWeek()
        {
            throw new System.NotImplementedException();
        }

        public void BuyMusician(Musician musician)
        {
            Musicians.Add(musician);
            Budget -= musician.Price;
        }

        public void BuyPractice(Practice practice)
        {
            UnusedActivities.Add(practice);
        }

        public void BuyTrip(Trip trip)
        {
            if (Budget >= trip.Price)
            {
                Budget -= trip.Price;
                UnusedActivities.Add(trip);
            }
            else throw new NotEnoughMoneyException();

        }
        public void BuyConcert(Concert concert)
        {
            if (Budget >= concert.Price)
            {
                if (Experience >= concert.RequiredExperience)
                {
                    Budget -= concert.Price;
                    UnusedActivities.Add(concert);
                }
                else throw new NotEnoughExperienceException();
            }
            else throw new NotEnoughMoneyException();
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